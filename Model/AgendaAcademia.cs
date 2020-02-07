using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class AgendaAcademia
    {
        public string Titulo { get; set; }
        public string Proprietario { get; set; }
        public string Comentario { get; set; }
        List<Contato> Contatos { get; set; }
        List<Evento> Eventos { get; set; }
        List<Nota> Notas { get; set; }
    }
}
