Imports System
Module boletin_academico
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim materias(9) As String
        Dim notas1(9) As Double
        Dim notas2(9) As Double
        Dim notas3(9) As Double
        Dim promedios(9) As Double
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------'
        '--|menu_principal_de_boletin_academico|--'
        '-----------------------------------------'
        Do
            Console.WriteLine("menu principal de boletin academico")
            Console.WriteLine("1) Registrar estudiante")
            Console.WriteLine("2) Editar estudiante")
            Console.WriteLine("3) Listar estudiantes")
            Console.WriteLine("4) Buscar estudiante")
            Console.WriteLine("5) Eliminar estudiante")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '--------------------------'
                '--|registrar_estudiante|--'
                '--------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas estudiantes.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre del estudiante: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Materia: ")
                        materias(cantidad) = Console.ReadLine()
                        Console.Write("Nota 1: ")
                        notas1(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Nota 2: ")
                        notas2(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Nota 3: ")
                        notas3(cantidad) = Convert.ToDouble(Console.ReadLine())
                        promedios(cantidad) = (notas1(cantidad) + notas2(cantidad) + notas3(cantidad)) / 3
                        If promedios(cantidad) >= 3.0 Then
                            estados(cantidad) = "Aprobado"
                        Else
                            estados(cantidad) = "Reprobado"
                        End If
                        cantidad += 1
                        Console.WriteLine("Estudiante registrado correctamente.")
                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Materia: " & materias(cantidad - 1) & " | Nota 1: " & notas1(cantidad - 1) & " | Nota 2: " & notas2(cantidad - 1) & " | Nota 3: " & notas3(cantidad - 1) & " | Promedio: " & promedios(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                    End If
                '-----------------------'
                '--|editar_estudiante|--'
                '-----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estudiantes registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Materia: " & materias(i) & " | Nota 1: " & notas1(i) & " | Nota 2: " & notas2(i) & " | Nota 3: " & notas3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del estudiante a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nueva materia: ")
                            materias(posicion) = Console.ReadLine()
                            Console.Write("Nueva nota 1: ")
                            notas1(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva nota 2: ")
                            notas2(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva nota 3: ")
                            notas3(posicion) = Convert.ToDouble(Console.ReadLine())
                            promedios(posicion) = (notas1(posicion) + notas2(posicion) + notas3(posicion)) / 3
                            If promedios(posicion) >= 3.0 Then
                                estados(posicion) = "Aprobado"
                            Else
                                estados(posicion) = "Reprobado"
                            End If
                            Console.WriteLine("Estudiante actualizado correctamente.")
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Materia: " & materias(posicion) & " | Nota 1: " & notas1(posicion) & " | Nota 2: " & notas2(posicion) & " | Nota 3: " & notas3(posicion) & " | Promedio: " & promedios(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|listar_estudiantes|--'
                '------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estudiantes registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Materia: " & materias(i) & " | Nota 1: " & notas1(i) & " | Nota 2: " & notas2(i) & " | Nota 3: " & notas3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '-----------------------'
                '--|buscar_estudiante|--'
                '-----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estudiantes registrados.")
                    Else
                        Console.Write("Ingrese el ID del estudiante a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Materia: " & materias(posicion) & " | Nota 1: " & notas1(posicion) & " | Nota 2: " & notas2(posicion) & " | Nota 3: " & notas3(posicion) & " | Promedio: " & promedios(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|eliminar_estudiante|--'
                '-------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estudiantes registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Materia: " & materias(i) & " | Nota 1: " & notas1(i) & " | Nota 2: " & notas2(i) & " | Nota 3: " & notas3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del estudiante a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                materias(i) = materias(i + 1)
                                notas1(i) = notas1(i + 1)
                                notas2(i) = notas2(i + 1)
                                notas3(i) = notas3(i + 1)
                                promedios(i) = promedios(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Estudiante eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estudiantes registrados.")
                    Else
                        Dim aprobados As Integer = 0
                        Dim reprobados As Integer = 0
                        Dim sumaPromedios As Double = 0
                        Dim sumaNota1 As Double = 0
                        Dim sumaNota2 As Double = 0
                        Dim sumaNota3 As Double = 0
                        Dim notaMayor As Double = notas1(0)
                        Dim notaMenor As Double = notas1(0)
                        Dim estudianteMayor As String = nombres(0)
                        Dim estudianteMenor As String = nombres(0)
                        Dim promedioMayor As Double = promedios(0)
                        Dim promedioMenor As Double = promedios(0)
                        Dim estudiantePromedioMayor As String = nombres(0)
                        Dim estudiantePromedioMenor As String = nombres(0)
                        For i As Integer = 0 To cantidad - 1
                            sumaPromedios += promedios(i)
                            sumaNota1 += notas1(i)
                            sumaNota2 += notas2(i)
                            sumaNota3 += notas3(i)
                            If estados(i) = "Aprobado" Then
                                aprobados += 1
                            Else
                                reprobados += 1
                            End If
                            If notas1(i) > notaMayor Then
                                notaMayor = notas1(i)
                                estudianteMayor = nombres(i)
                            End If
                            If notas1(i) < notaMenor Then
                                notaMenor = notas1(i)
                                estudianteMenor = nombres(i)
                            End If
                            If promedios(i) > promedioMayor Then
                                promedioMayor = promedios(i)
                                estudiantePromedioMayor = nombres(i)
                            End If
                            If promedios(i) < promedioMenor Then
                                promedioMenor = promedios(i)
                                estudiantePromedioMenor = nombres(i)
                            End If
                        Next
                        Dim promedioGeneral As Double = sumaPromedios / cantidad
                        Dim promedioNota1 As Double = sumaNota1 / cantidad
                        Dim promedioNota2 As Double = sumaNota2 / cantidad
                        Dim promedioNota3 As Double = sumaNota3 / cantidad
                        Dim promedioIgualSuperior4 As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If promedios(i) >= 4.0 Then
                                promedioIgualSuperior4 += 1
                            End If
                        Next
                        Console.WriteLine("Estudiantes: " & cantidad & " | Aprobados: " & aprobados & " | Reprobados: " & reprobados & " | Promedio general: " & promedioGeneral & " | Promedio nota 1: " & promedioNota1 & " | Promedio nota 2: " & promedioNota2 & " | Promedio nota 3: " & promedioNota3 & " | Nota mayor: " & notaMayor & " (" & estudianteMayor & ")" & " | Nota menor: " & notaMenor & " (" & estudianteMenor & ")" & " | Mayor promedio: " & promedioMayor & " (" & estudiantePromedioMayor & ")" & " | Menor promedio: " & promedioMenor & " (" & estudiantePromedioMenor & ")" & " | Promedios iguales o superiores a 4.0: " & promedioIgualSuperior4)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Boletin Academico.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module