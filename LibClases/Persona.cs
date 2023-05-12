namespace LibClases
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _correo;

        public Persona(string nombre, string apellido, string correo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _correo = correo;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Correo { get => _correo; set => _correo = value; }
    }
}