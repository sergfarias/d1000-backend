using System;
using System.Globalization;

namespace Shared.CrossCutting.Tools
{
    public static class DataHoraExtensions
    {
        private const string FORMATO_DATA_PADRAO = "dd/MM/yyyy";
        private const string FORMATO_DATAHORA_PADRAO = "dd/MM/yyyy HH:mm";
        private const string FORMATO_HORA_PADRAO = "HH:mm";

        #region Validacao

        public static bool AniversarioValido(this string date)
        {
            return Valida(string.Format("{0}/2000", date), FORMATO_DATA_PADRAO);
        }

        private static bool Valida(string date, string format)
        {
            var defaultDate = DateTime.Today;

            return DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out defaultDate);
        }

        public static bool DataValida(this string date, string format = null)
        {
            if (string.IsNullOrWhiteSpace(format))
                return Valida(date, FORMATO_DATA_PADRAO);

            return Valida(date, format);
        }

        #endregion

        #region From Date

        public static string DataFormatada(this DateTime date)
        {
            return DataFormatada(date, null);
        }

        public static string DataFormatada(this DateTime? date)
        {
            return DataFormatada(date, null);
        }

        public static string DataFormatada(this DateTime? date, string format)
        {
            if (date.HasValue)
            {
                return date.Value.DataFormatada(format);
            }

            return null;
        }

        public static string DataFormatada(this DateTime date, string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                format = FORMATO_DATA_PADRAO;

            return date.ToString(format);
        }

        #endregion

        #region From Datetime

        public static string DataHoraFormatada(this DateTime dateTime)
        {
            return DataHoraFormatada(dateTime, null);
        }

        public static string DataHoraFormatada(this DateTime? dateTime)
        {
            return DataHoraFormatada(dateTime, null);
        }

        public static string DataHoraFormatada(this DateTime? dateTime, string format)
        {
            if (dateTime.HasValue)
            {
                return dateTime.Value.DataHoraFormatada(format);
            }

            return null;
        }

        public static string DataHoraFormatada(this DateTime dateTime, string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                format = FORMATO_DATAHORA_PADRAO;

            return dateTime.ToString(format);
        }


        public static string HoraFormatada(this DateTime dateTime)
        {
            return HoraFormatada(dateTime, null);
        }

        public static string HoraFormatada(this DateTime? dateTime)
        {
            return HoraFormatada(dateTime, null);
        }

        public static string HoraFormatada(this DateTime? dateTime, string format)
        {
            if (dateTime.HasValue)
            {
                return dateTime.Value.HoraFormatada(format);
            }

            return null;
        }

        public static string HoraFormatada(this DateTime dateTime, string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                format = FORMATO_HORA_PADRAO;

            return dateTime.ToString(format);
        }

        #endregion

        #region To Date

        public static DateTime? Data(this string date)
        {
            return date.Data(null);

        }

        public static DateTime? Data(this string date, string format)
        {
            if (string.IsNullOrWhiteSpace(date))
                return new DateTime?();

            if (format == null)
                format = FORMATO_DATA_PADRAO;

            return DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
        }

        #endregion

        #region To Datetime

        public static DateTime? DataHora(this string date)
        {
            return date.Data(FORMATO_DATAHORA_PADRAO);
        }

        public static DateTime? DataHora(this string date, string time)
        {
            return date.DataHora(time, null);
        }

        public static DateTime? DataHora(this string date, string time, string format)
        {
            if (format == null)
                format = FORMATO_DATAHORA_PADRAO;

            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(time))
                return null;
            else
                return DateTime.ParseExact(string.Format("{0} {1}", date, time), format, CultureInfo.InvariantCulture);
        }

        #endregion

        public static bool CompararIgnorandoHora(DateTime? a, DateTime? b)
        {
            if (!a.HasValue && !b.HasValue)
                return true;
            
            if(a.HasValue && b.HasValue)
                return a.Value.Date == b.Value.Date;

            return false;
        }
    }
}
