using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace d1000.Common
{
    public class PropertyMapper
    {

        public class AssignedProperty : Attribute
        {
            public AssignedProperty(string PropertyName)
            {
                this.PropertyName = PropertyName;
            }

            public string PropertyName { get; set; }

            public override string ToString()
            {
                return PropertyName;
            }
        }

        public static void Map(object Object, IDataReader Reader)
        {
            List<string> Fields = new List<string>();
            for (int i = 0; i < Reader.FieldCount; i++)
                Fields.Add(Reader.GetName(i));

            foreach (var prop in Object.GetType().GetProperties())
            {
                object value;

                if (!Fields.Contains(prop.Name))
                    continue;

                try
                {
                    value = Reader[prop.Name];
                }
                catch
                {
                    continue;
                }

                try
                {
                    prop.SetValue(Object, value);
                }
                catch
                {
                    // Ignorar propriedade
                }
            }
        }

        public static void Map(object Object, DataRow Row)
        {
            foreach (var prop in Object.GetType().GetProperties())
            {
                object value;

                if (!Row.Table.Columns.Contains(prop.Name))
                    return;

                try
                {
                    value = Row[prop.Name];
                }
                catch
                {
                    continue;
                }

                try
                {
                    prop.SetValue(Object, value);
                }
                catch
                {
                    // Ignorar propriedade
                }
            }
        }

        public static object MapTo<T>(IDataReader reader)
        {
            var obj = Activator.CreateInstance<T>();

            Map(obj, reader);

            return obj;
        }

        public static IEnumerable<T> MapToList<T>(IDataReader reader)
        {
            List<T> Itens = new List<T>();

            while(reader.Read())
            {
                var obj = Activator.CreateInstance<T>();

                Map(obj, reader);

                Itens.Add(obj);
            }

            return Itens;
        }

        public static void AssignProperties(object Source, object Destination, bool IgnoreFlag = false)
        {
            foreach (var prop in Source.GetType().GetProperties())
            {
                var attr = (from a
                            in prop.GetCustomAttributesData()
                            where a.AttributeType.Name == "AssignedProperty"
                            select a).FirstOrDefault();

                if (attr == null)
                    continue;

                var propertyName = attr.ConstructorArguments[0].Value.ToString();
                var dProperty = Destination.GetType().GetProperty(propertyName);

                if (dProperty == null)
                    continue;

                object srcVal = prop.GetValue(Source);

                if (typeof(long) == srcVal.GetType() && dProperty.PropertyType == typeof(int))
                    srcVal = Convert.ToInt32(srcVal);

                try
                {
                    dProperty.SetValue(Destination, srcVal);
                }
                catch
                {
                    // Ignorar propriedade
                }
            }
        }

    }

}
