int cant = 5;
string tareRS;
int tareR;
bool esTareaR;

List <Tarea> TareasPendientes = new List<Tarea>();
List <Tarea> TareasRealizadas = new List<Tarea>();

string[] descripciones = {"imprimir", "estudiar Taller", "barrer pieza", "ensallar"};
Random rand = new Random();

int identificador = 0;

for (int i=0; i < cant; i++)
{
    int indice = rand.Next(0, 4);
    string descrip = descripciones[indice];
    int duracion = rand.Next(10, 100);
    Tarea miTarea = new Tarea(identificador, descrip, duracion);
    TareasPendientes.Add(miTarea);
    identificador++;
}

foreach (var tare in TareasPendientes)
{
    Console.WriteLine("Tarea " + tare.TareaID);
    Console.WriteLine("\t"+tare.Descripcion);
    Console.WriteLine("\t"+tare.Duracion);
    Console.WriteLine("\t"+tare.Estado);
}

do 
{
    Console.WriteLine("ingrese la tarea que desea marcar como realizada: ");
    tareRS = Console.ReadLine();
    esTareaR = int.TryParse(tareRS, out tareR)
}while(!esTareaR);

int i = 0;

foreach(var tare in TareasPendientes)
{
    if(tare.TareaID == tareR)
}

