public class Tarea
{
    public Tarea(int id, string descrip, int duracion)
    {
        tareaID = id;
        Descripcion = descrip;
        Duracion = duracion;
        estado = Estado.pendiente;
    }

    private int tareaID;
    private string descripcion;
    private int duracion;
    private Estado estado;
    public int TareaID { get => tareaID; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public Estado Estado { get => estado; }
}


public enum Estado
    {
        pendiente,
        realizada
    }
