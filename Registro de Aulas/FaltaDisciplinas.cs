using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Aulas
{
    public class FaltaDisciplinas
    {

        #region Construtor

        public FaltaDisciplinas(string turma, string disciplina, int horas)
        {
            this.Turma = turma;
            this.Disciplina = disciplina;
            this.Horas = horas;
        }


        #endregion



        #region Campos

        private string _turma;
        private string _disciplinas;
        private int _horas;


        #endregion



        #region Propriedades

        public string Turma
        {
            set
            {
                _turma = value;
            }
            get 
            { 
                return _turma; 
            }
        }

        public string Disciplina
        {
            set
            {
                _disciplinas = value;
            }
            get
            {
                return _disciplinas;
            }
        }

        public int Horas
        {
            set
            {
                _horas = value;
            }
            get
            {
                return _horas;
            }
        }


        #endregion

    }
}
