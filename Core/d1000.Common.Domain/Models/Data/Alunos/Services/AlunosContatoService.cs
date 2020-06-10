using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Repositories;
using d1000.Common.Domain.Models.Data.Alunos.Interfaces.Services;
using Shared.Domain.Impl.Validator;
using Shared.Domain.Interface.Validator;
using Shared.Domain.Service;

namespace d1000.Common.Domain.Models.Data.Alunos.Services
{
    public class AlunosContatoService : BaseCrudService<DML_BA_ALUNO_CONTATO>, IAlunosContatoService
    {
        private IAlunosContatoRepository repository;

        public AlunosContatoService(IAlunosContatoRepository repository, IValidationService validationService) : base(repository, validationService)
        {
            this.repository = repository;
        }
        public override ResultadoValidacao InserirRetornaModel(DML_BA_ALUNO_CONTATO model)
        {
            var resultado = base.InserirRetornaModel(model);
            return resultado;
        }
        bool IAlunosContatoService.ExisteContatoCadastrado(int id_contato)
        {
            return repository.ExisteContatoCadastrado(id_contato);
        }
    }
}
