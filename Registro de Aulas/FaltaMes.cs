using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Aulas
{
    internal class FaltaMes
    {

        #region Construtor

        public FaltaMes(DateTime data)
        {
            this.Data = data;
            this.Faltas = new List<FaltaDisciplinas>();
        }


        #endregion



        #region Campos

        private DateTime _data;
        List<FaltaDisciplinas> _faltas;


        #endregion



        #region Propriedades

        public DateTime Data
        {
            set
            {
                _data = value;
            }
            get
            {
                return _data;
            }
        }

        public List<FaltaDisciplinas> Faltas
        {
            set
            {
                _faltas = value;
            }
            get
            {
                return _faltas;
            }
        }


        #endregion



        #region Metodos

        public void AddFalta(FaltaDisciplinas falta)
        {
            _faltas.Add(falta);
        }

        public void DelFalta(FaltaDisciplinas falta)
        {
            _faltas.Remove(falta);
        }


        #endregion


    }
}
