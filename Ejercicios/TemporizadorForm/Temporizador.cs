using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemporizadorForm
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador eventoTemporizador;


        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Task hilo; 
        private int intervalo;

        public bool EstaActivo
        {
            get
            {
                return hilo is not null && (hilo.Status == TaskStatus.Running);
            }
        }

        public int Intervalo
        {
            get { return intervalo; }
        }

        public void CorrerTiempo()
        {
            while (eventoTemporizador is not null && !cancellationToken.IsCancellationRequested)
            {
                eventoTemporizador.Invoke();
                Thread.Sleep(Intervalo);
            }
        }
        public void DetenerTiempo()
        {
            if(EstaActivo)
            {
                cancellationTokenSource.Cancel();
            }
        }
        public void IniciarTemporizador()
        {
            if(!EstaActivo)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                hilo = Task.Run(CorrerTiempo);
            }
        }
        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }
    }
}
