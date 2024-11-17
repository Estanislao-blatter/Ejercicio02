namespace Ejercicio02.Entidades
{
    public class Rectangulo
    {
        public int LadoMayor { get; set; }
        public int LadoMenor { get; set; }
        #region Constructores
        public Rectangulo(int ladoMayor, int ladoMenor)
        {
            LadoMayor = ladoMayor;
            LadoMenor = ladoMenor;
        }

        public Rectangulo()
        {

        }
        #endregion


        public double GetPerimetro() => 2 * LadoMayor + 2 * LadoMenor;
        public double GetSuperficie() => LadoMayor * LadoMenor;
    }
}
