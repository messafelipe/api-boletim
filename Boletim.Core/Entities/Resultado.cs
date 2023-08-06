using Boletim.Core.Enums;

namespace Boletim.Core.Entities
{
    public class Resultado //: BaseEntity
    {
        public Resultado(double media_Final, ResultadoFinalEnum resultado_Final, int id_Aluno)
        {
            Media_Final = media_Final;
            Resultado_Final = resultado_Final;
            Id_Aluno = id_Aluno;
        }

        public double Media_Final { get; private set; }

        public ResultadoFinalEnum Resultado_Final { get; private set; }

        public int Id_Aluno { get; private set; }
    }
}
