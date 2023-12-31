﻿using Boletim.Core.Enums;

namespace Boletim.Core.Entities
{
    public class Resultado : BaseEntity
    {
        public Resultado(int id, SituacaoEnum 
            situacao, int idAluno) : base(id)
        {
            Situacao = situacao;
            IdAluno = idAluno;
        }

        public SituacaoEnum Situacao { get; private set; }

        public int IdAluno { get; private set; }
    }
}
