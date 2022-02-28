using System;

namespace Juego_Consola_Linux
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cambio de color en letras
            Console.ForegroundColor = ConsoleColor.Green;
            //Nombre del juego
            Console.WriteLine("\n" +
"                              ┌───── •✧✧• ─────┐\n" +
"                               - H4ck th3 G4m3 -\n" +
"                              └───── •✧✧• ─────┘");
            //Declaracion de variables

            string info = "Sudo su = Entrar como Admin\n" +
                    "ls = te mostrara en pantalla los archivos\n" +
                    "cd + nombre de la carpeta = Entraras a la carpeta seleccionada\n" +
                    "mkdir + nombre de una nueva carpeta = Sirve para crear una carpeta\n" +
                    "touch + nombre de nuevo archivo = Creara un nuevo archivo\n" +
                    "del + Nombre del archivo = Eliminaras el archivo o carpeta seleccionada\n" +
                    "ping + IP = Realizara un envio de paquetes y te dira si se reciben o no\n" +
                    "download + Nombre del archivo = Descargara el archivo seleccionado\n" +
                    "connect + ip = Te conectara a la ip elegida \n" +
                    "disconnect = te desconectara de la ip a la que te conectaste";
            int Global_Marker = 0;
            int descripction1 = 0;
            int descripction2 = 0;
            int descripction3 = 0;
            int descripction4 = 0;
            int descripction5 = 0;
            int cases;
            string Lenguage, user, password, sudo, answare, answare2, answare3, answare4, answare5, answare6, answare7, answare8, answare9;


            //Comienza el juego

            Console.WriteLine("Elige un idioma");
            Console.WriteLine("Español o Ingles");
            Lenguage = Console.ReadLine().ToUpper();

            //LENGUAJE ESPANOL
            if (Lenguage == "ESPAÑOL" || Lenguage == "ESPANOL")
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a H4ck th3 G4m3 seras hacker por 1 dia, pero primero aprenderas lo basico");
                Console.WriteLine("estamos instalacion tu nuevo sistema operativo...");
                Console.WriteLine("Presiona enter para continuar...");
                Console.ReadKey();
                Console.Clear();

                //Guardado de usuario y contrasena
                Console.WriteLine("Todo listo");
                Console.WriteLine("tu nombre de usuario es: user");
                Console.WriteLine("tu contraseña es: 1234 ");
                Console.WriteLine("Guardalas bien las necesitaras mas adelante");
                Console.ReadKey();
                Console.Clear();


                //Informacion para el usuario

                Console.WriteLine("Los comandos de consola que vas a necesitar son...");
                Console.WriteLine("Sudo su = Entrar como Admin\n" +
                    "ls = te mostrara en pantalla los archivos\n" +
                    "cd + nombre de la carpeta = Entraras a la carpeta seleccionada\n" +
                    "mkdir + nombre de una nueva carpeta = Sirve para crear una carpeta\n" +
                    "touch + nombre de nuevo archivo = Creara un nuevo archivo\n" +
                    "del + Nombre del archivo = Eliminaras el archivo o carpeta seleccionada\n" +
                    "ping + IP = Realizara un envio de paquetes y te dira si se reciben o no\n" +
                    "download + Nombre del archivo = Descargara el archivo seleccionado\n" +
                    "connect + ip = Te conectara a la ip elegida \n" +
                    "disconnect = te desconectara de la ip a la que te conectaste");
                Console.WriteLine("Recuerda que siempre puedes ver esta informacion escribiendo info en la consola");
                Console.ReadKey();
                Console.Clear();

                //Decision del jugador si o no
                Console.WriteLine("Te parece si hacemos algunos ejercicios?");
                answare = Console.ReadLine().ToUpper();

                //Arreglo para esta seccion con el si escribe info
                if (answare == "INFO")
                {
                    Console.WriteLine(info);
                }

                else if (answare == "SI")
                {
                    Console.WriteLine("Perfecto comencemos...");


                    do
                    {
                        Console.WriteLine("Haz realizado " + Global_Marker + " ejercicios");
                        Console.WriteLine("Elige el ejercicio que quieres realizar\n" +
                                            "1 Entrar en modo admin\n" +
                                             "2 Entrar a una carpeta por comando y crear un archivo .txt\n" +
                                             "3 Verificar si una IP tiene conexcion y regresa los paquetes\n" +
                                             "4 Conectarte y desconectarte de una IP\n" +
                                             "5 Eliminar un archivo mediante comandos\n");
                        cases = Convert.ToInt32(Console.ReadLine());

                        switch (cases)
                        {
                            //caso 1
                            case 1:
                                if (descripction1 == 0)
                                {
                                    Console.WriteLine("Bien, recuerda que para entrar como super usuario tienes que escribir sudo su te pedira tu usuario y contraseña.");
                                    Console.WriteLine("user@no_admin");
                                    sudo = Console.ReadLine().ToUpper();

                                    if (sudo == "SUDO SU")
                                    {
                                        do
                                        {
                                            Console.WriteLine("Usuario: ");
                                            user = Console.ReadLine();
                                        } while (user != "user");
                                        do
                                        {
                                            Console.WriteLine("Ingresa tu contraseña");
                                            password = Console.ReadLine();


                                        } while (password != "1234");

                                        Console.WriteLine(user + "@admin");
                                        Console.WriteLine("Excelente lograsete entrar como admin");
                                        Console.ReadKey();
                                        Console.Clear();
                                        descripction1 = descripction1 + 1;
                                        Global_Marker = Global_Marker + 1;

                                    }

                                    else if (sudo == "INFO")
                                    {
                                        Console.WriteLine(info);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }


                                    else if (sudo != "SUDO SU" || sudo != "INFO")
                                    {
                                        Console.WriteLine("Si no recuerdas un comando recuerda que siempre puedes poner info en la consola para recibir mas informacion");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }
                                else if (descripction1 != 0)
                                {
                                    Console.WriteLine("Este ejercicio ya se realizo");
                                    Console.ReadKey();
                                    Console.Clear();
                                }


                                break;

                            //caso 2

                            case 2:
                                if (descripction2 == 0)
                                {
                                    Console.WriteLine("Para entrar a una carpeta mediante comandos primero hay que identificar la nombre de la carpeta escribiendo 'ls'");
                                    Console.WriteLine("Identificada la carpeta procedemos a escribir en consola 'cd' mas el nombre de la carpeta");
                                    Console.WriteLine("Identifica la carpeta 'Documentos' y entra en ella");
                                    Console.WriteLine("user@admin:");
                                    answare2 = Console.ReadLine().ToUpper();

                                    if (answare2 == "LS")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("'Documentos'\n 'Imagenes' \n 'Videos' \n 'Descargas' ");
                                        answare3 = Console.ReadLine().ToUpper();

                                        if (answare3 == "CD DOCUMENTOS")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tarea_progra.cs\n Tarea_Psico_Color.pdf \n Tarea_dis_pers.jpg");
                                            Console.WriteLine("Lo lograste pudiste entrar a la carpeta correctamente");
                                            descripction2 = descripction2 + 1;
                                            Global_Marker = Global_Marker + 1;
                                            Console.ReadKey();
                                            Console.Clear();
                                        }

                                        else if (answare3 == "INFO")
                                        {
                                            Console.WriteLine(info);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }

                                        else if (answare3 != "INFO" || answare3 != "CD DOCUMENTOS")
                                        {
                                            Console.WriteLine("Si no recuerdas un comando pudes escribir info en la consola...");
                                        }
                                        {
                                            Console.WriteLine(info);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }

                                    else if (answare2 == "INFO")
                                    {
                                        Console.WriteLine(info);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    else if (answare2 != "LS" || answare2 != "INFO")
                                    {
                                        Console.WriteLine("Si no recuerda un comando, puedes escribir info en la consola");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }

                                else if (descripction2 != 0)
                                {
                                    Console.WriteLine("Este ejercicio ya se realizo");
                                }
                                break;

                            //case 3

                            case 3:
                                if (descripction3 == 0)
                                {
                                    Console.WriteLine("Para verificar si una IP esta conectada o no se escribe el comando ping mas la IP ejemplo ping 172.168.0.1");
                                    Console.WriteLine("Este comando enviara algunos paquetes y los recibira de vuelta, si esto no sucede el equipo se encuentra desconectado");
                                    Console.WriteLine("Envia una traza a la direccion IP 192.168.100.20");
                                    Console.WriteLine("user@admin: ");
                                    answare4 = Console.ReadLine().ToUpper();

                                    if (answare4 == "PING 192.168.100.20")
                                    {
                                        Console.WriteLine("Estadísticas de ping para 192.168.100.20\n" +
                                                          "Paquetes: enviados = 4, recibidos = 4, perdidos = 0\n" +
                                                          "(0 % perdidos),\n" +
                                                          "Tiempos aproximados de ida y vuelta en milisegundos:\n" +
                                                          "Mínimo = 11ms, Máximo = 12ms, Media = 11ms");
                                        Console.WriteLine("Haz enviado 4 paquetes y recibido 4 paquetes");
                                        Console.WriteLine("Lo lograste");
                                        descripction3 = descripction3 + 1;
                                        Global_Marker = Global_Marker + 1;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    else if (answare4 == "INFO")
                                    {
                                        Console.WriteLine(info);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    else if (answare4 != "INFO" || answare4 != "PING 192.168.100.20")
                                    {
                                        Console.WriteLine("Si no recuerda un comando, puedes escribir info en la consola");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }

                                else if (descripction3 != 0)
                                {
                                    Console.WriteLine("Este ejercicio ya se realizo");
                                }
                                break;

                            //case 4

                            case 4:
                                if (descripction4 == 0)
                                {
                                    Console.WriteLine("Ahora veremos como conectarnos a una IP...");
                                    Console.WriteLine("Recuerda que esto es solo un juego y no es tan sencillo conectarte a una IP");
                                    Console.WriteLine("La idea es que familiarices con los comandos en consola");
                                    Console.WriteLine("Recuerda que para conectar a una ip usaremos el comando connect y para desconectarnos usaremos el comando disconect");
                                    Console.WriteLine("Ejemplo de connect: connect XXX.168.100.1");
                                    Console.WriteLine("Ejemplo de disconnect: disconnect XXX.168.100.1");
                                    Console.WriteLine("Conectate y desconectate a la IP 172.168.100.5");
                                    Console.WriteLine("user@admin: ");
                                    answare5 = Console.ReadLine().ToUpper();
                                    if (answare5 == "CONNECT 172.168.100.5")
                                    {
                                        Console.WriteLine("Conectando....");
                                        Console.WriteLine("Conexion existosa a 172.168.100.5");
                                        Console.WriteLine("El usuario se dio cuenta de la conexion DESCONECTATE usando disconnect");
                                        answare6 = Console.ReadLine().ToUpper();

                                        if (answare6 == "DISCONNECT")
                                        {
                                            Console.WriteLine("Desconectado...");
                                            Console.WriteLine("Conexion finalizada.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Felicidades lograste conectarte y desconectarte de una IP");
                                            Console.ReadKey();
                                            Console.Clear();
                                            descripction4 = descripction4 + 1;
                                            Global_Marker = Global_Marker + 1;
                                        }
                                        else if (answare6 == "INFO")
                                        {
                                            Console.WriteLine(info);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else if (answare6 != "DISCONNECT" || answare6 != "INFO")
                                        {
                                            Console.WriteLine("Si no recuerda un comando, puedes escribir info en la consola");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }


                                    }
                                    else if (answare5 == "INFO")
                                    {
                                        Console.WriteLine(info);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    else if (answare5 != "INFO" || answare5 != "CONNECT 172.168.100.5")
                                    {
                                        Console.WriteLine("Si no recuerda un comando, puedes escribir info en la consola");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }

                                else if (descripction4 != 0)
                                {
                                    Console.WriteLine("Este ejercicio ya se realizo");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                break;

                            //case 5
                            case 5:
                                if (descripction5 == 0)
                                {
                                    Console.WriteLine("Hagamos una tarea sencilla elimnar un archivo de una carpeta");
                                    Console.WriteLine("Recuerda para entrar a una carpeta mediante comandos primero hay que identificar la nombre de la carpeta escribiendo 'ls'");
                                    Console.WriteLine("Identificada la carpeta procedemos a escribir en consola 'cd' mas el nombre de la carpeta");
                                    Console.WriteLine("Para eliminar un archivo utiliza el comando 'del'");
                                    Console.WriteLine("Identifica la carpeta 'Documentos' y entra en ella y elimina el archivo Tarea_progra.cs");
                                    Console.WriteLine("user@admin:");
                                    answare7 = Console.ReadLine().ToUpper();

                                    if (answare7 == "LS")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("'Documentos'\n 'Imagenes' \n 'Videos' \n 'Descargas' ");
                                        answare8 = Console.ReadLine().ToUpper();

                                        if (answare8 == "CD DOCUMENTOS")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tarea_progra.cs\n Tarea_Psico_Color.pdf \n Tarea_dis_pers.jpg");
                                            Console.WriteLine("user@admin: ");
                                            answare9 = Console.ReadLine().ToUpper();

                                            if (answare9 == "DEL TAREA_PROGRA.CS")
                                            {
                                                Console.WriteLine("Eliminando archivo...");
                                                Console.WriteLine("Archivo eliminado correctamente");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Console.WriteLine("Lo haz logrado eliminaste el archivo correctamente");
                                                Console.ReadKey();
                                                Console.Clear();
                                                descripction5 = descripction5 + 1;
                                                Global_Marker = Global_Marker + 1;
                                            }
                                            else if (answare9 == "INFO")
                                            {
                                                Console.WriteLine(info);
                                                Console.ReadKey();
                                                Console.Clear();
                                            }

                                            else if (answare9 != "DEL TAREA_PROGRA.CS" || answare9 != "INFO")
                                            {
                                                Console.WriteLine("Si no recuerdas un comando pudes escribir info en la consola...");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }

                                        }

                                        else if (answare8 == "INFO")
                                        {
                                            Console.WriteLine(info);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }

                                        else if (answare8 != "INFO" || answare8 != "CD DOCUMENTOS")
                                        {
                                            Console.WriteLine("Si no recuerdas un comando pudes escribir info en la consola...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }

                                    }

                                    else if (answare7 == "INFO")
                                    {
                                        Console.WriteLine(info);
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    else if (answare7 != "LS" || answare7 != "INFO")
                                    {
                                        Console.WriteLine("Si no recuerda un comando, puedes escribir info en la consola");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }

                                else if (descripction5 != 0)
                                {
                                    Console.WriteLine("Este ejercicio ya se realizo");
                                }
                                break;
                        }

                    } while (Global_Marker != 5);

                    Console.WriteLine("Terminastes " + Global_Marker + "Ejercicios");
                    Console.WriteLine("Felicidades lograste completar todos los ejercicios");
                    Console.WriteLine("bye bye");
                    Console.ReadKey();
                    Console.Clear();
                }


                else if (answare == "NO")
                {
                    Console.WriteLine("Otro dia sera... bye bye");
                    Console.ReadKey();
                }




            }

            //LENGUAJE INGLES
            else if (Lenguage == "INGLES")
            {
                Console.Clear();
                Console.WriteLine("we are working on the translation to your language, we are sorry");

            }
            //No se eligio un lenaguje correcto
            else if (Lenguage != "ESPAÑOL" || Lenguage != "ESPANOL" || Lenguage == "INGLES")
            {
                Console.Clear();
                Console.WriteLine("No tenemos ese idioma");
            }

            Console.ReadKey();
        }
    }
}