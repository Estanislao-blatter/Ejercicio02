using Ejercicio02.Entidades;

namespace Ejercicio02.Datos
{
    public class RepositorioDeRectangulo
    {
        private List<Rectangulo> rectangulos = null!;
        public RepositorioDeRectangulo() 
        { 
           rectangulos= new List<Rectangulo>();
            LeerDatos();
        }
        public List<Rectangulo> GetLista() 
        { 
            return rectangulos;
        }
        public int GetCantidad()=> rectangulos.Count;

        public void GetAgregar(Rectangulo rNuevo)
        {
            rectangulos.Add(rNuevo);
        }

        public bool Existe(Rectangulo rNuevo)
        {
            return rectangulos.Any(r => r.LadoMayor == rNuevo.LadoMayor && r.LadoMenor == rNuevo.LadoMenor);
        }
        public void Borrar(Rectangulo rBorrar)
        {
            rectangulos.Remove(rBorrar);
        }

        public List<Rectangulo>? Filtrar(int superficieFiltro)
        {
           return rectangulos.Where(r => r.GetSuperficie() >= superficieFiltro).ToList();
        }
        public int GetCantidad(int superficieFiltro)
        {
           return rectangulos.Count(r => r.GetSuperficie() >= superficieFiltro);
        }
        public void GuardarDatos()
        {
            var rutaEjecucionPrograma = AppDomain.CurrentDomain.BaseDirectory;
            var nombreArchivo = "Rectangulos.txt";
            var rutaArcichoCompleta=Path.Combine(rutaEjecucionPrograma, nombreArchivo);
            using (var escritor=new StreamWriter(rutaArcichoCompleta))
            {
                foreach(var rectangulo in rectangulos) 
                {
                    var linea=ConstruirLinea(rectangulo);
                    escritor.WriteLine(linea);
                }
                escritor.Close();
            }
        }

        private string ConstruirLinea(Rectangulo rectangulo)
        {
            return $"{rectangulo.LadoMayor} | {rectangulo.LadoMenor}";
        }
        private void LeerDatos()
        {
            var rutaEjecucionPrograma = AppDomain.CurrentDomain.BaseDirectory;
            var nombreArchivo = "Rectangulos.txt";
            var rutaArcichoCompleta = Path.Combine(rutaEjecucionPrograma, nombreArchivo);
            if (!File.Exists(rutaArcichoCompleta)) { return; }
            using (var lector = new StreamReader(rutaArcichoCompleta))
            {
                while (!lector.EndOfStream) 
                { 
                   string? lineaLeida=lector.ReadLine();
                   Rectangulo? rectangulo = ConstruirRectangulo(lineaLeida);
                    if (rectangulo is null) return;
                    rectangulos.Add(rectangulo);
                }
                lector.Close();
            }
        }

        private Rectangulo? ConstruirRectangulo(string? lineaLeida)
        {
            if (lineaLeida is null) return null;
            var campos = lineaLeida.Split('|');
            var ladoMayor = int.Parse(campos[0]);
            var ladoMenor = int.Parse(campos[1]);
            return new Rectangulo(ladoMayor, ladoMenor);
        }
    }
}
