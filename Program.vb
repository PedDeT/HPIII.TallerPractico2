Imports System
Imports System.Reflection.Metadata.Ecma335
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub precio_neto(ByVal nombre_empresa As String)
        Console.WriteLine("CALCULO DE PRECIO NETO")
        Dim nombre_producto, opcion_descuento, opcion_cantidad_descuento As String
        Dim precio_unitario, cantidad, total_neto, total_bruto, cantidad_descuento, total_descuento As Single
        Console.WriteLine("INGRESE EL NOMBRE DEL PRODUCTO")
        nombre_producto = Console.ReadLine()
        While True
            Console.WriteLine("INGRESE LA CANTIDAD DEL PRODUCTO")
            Dim entrada_cantidad_producto As String = Console.ReadLine()
            If Single.TryParse(entrada_cantidad_producto, cantidad) AndAlso cantidad > 0 Then
                Exit While
            Else
                Console.WriteLine("ENTRADA INVALIDA! POR FAVOR INGRESE UNA CANTIDAD VALIDA")
            End If
        End While
        While True
            Console.WriteLine("INGRESE EL PRECIO UNITARIO")
            Dim entrada_precio_unitario As String = Console.ReadLine()
            If Single.TryParse(entrada_precio_unitario, precio_unitario) AndAlso cantidad > 0 Then
                Exit While
            Else
                Console.WriteLine("ENTRADA INVALIDA! POR FAVOR INGRESE UNA CANTIDAD VALIDA")
            End If
        End While
        Do While True
            Console.WriteLine("EL ARTICULO TIENE DESCUENTO?")
            Console.WriteLine("1.Si")
            Console.WriteLine("2.No")
            Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
            opcion_descuento = Console.ReadLine()
            Select Case opcion_descuento
                Case "1"
                    Do While True
                        Console.WriteLine("ESCOJA EL DESCUENTO DEL PRODUCTO")
                        Console.WriteLine("1.7%")
                        Console.WriteLine("2.10%")
                        Console.WriteLine("3.20%")
                        Console.WriteLine("4.30%")
                        Console.WriteLine("5.40%")
                        Console.WriteLine("6.50%")
                        opcion_cantidad_descuento = Console.ReadLine()
                        Select Case opcion_cantidad_descuento
                            Case "1"
                                cantidad_descuento = 0.07
                                Exit Do
                            Case "2"
                                cantidad_descuento = 0.1
                                Exit Do
                            Case "3"
                                cantidad_descuento = 0.2
                                Exit Do
                            Case "4"
                                cantidad_descuento = 0.3
                                Exit Do
                            Case "5"
                                cantidad_descuento = 0.4
                                Exit Do
                            Case "6"
                                cantidad_descuento = 0.5
                                Exit Do
                            Case Else
                                Console.WriteLine("SELECCION INVALIDA! POR FAVOR INGRESE UNA OPCION VALIDA")
                        End Select
                    Loop
                    Exit Do
                Case "2"
                    cantidad_descuento = 0
                    Exit Do
                Case Else
                    Console.WriteLine("SELECCION INVALIDA! POR FAVOR INGRESE UNA OPCION VALIDA")
            End Select
        Loop
        total_bruto = precio_unitario * cantidad
        total_descuento = total_bruto * cantidad_descuento
        total_neto = total_bruto - total_descuento
        Console.WriteLine(nombre_empresa)
        Console.WriteLine(nombre_producto)
        Console.WriteLine($"CANTIDAD: {cantidad.ToString("F2")}")
        Console.WriteLine($"PRECIO POR UNIDAD: {precio_unitario.ToString("F2")}")
        Console.WriteLine($"TOTAL BRUTO: {total_bruto.ToString("F2")}")
        Console.WriteLine($"DESCUENTO: {(cantidad_descuento * 100).ToString("F2")}%")
        Console.WriteLine($"TOTAL DESCUENTO: {total_descuento.ToString("F2")}")
        Console.WriteLine($"TOTAL NETO: {total_neto.ToString("F2")}")
        Console.WriteLine("Presione cualquier tecla para continuar")
        Console.ReadKey()
    End Sub

    Sub Main(args As String())
        Dim opcion_menu_principal, nombre_empleado As String
        Dim nombre_empresa As String = "GRUPO CONTABLESA"
        Console.WriteLine(nombre_empresa)
        Console.WriteLine("BIENVENIDO")
        Do While True
            Console.WriteLine("MENU PRINCIPAL")
            Console.WriteLine("1. CALCULO DE PRECIO DE PRODUCTO")
            Console.WriteLine("2. CALCULO DE SUELDO Y LIQUIDACION")
            Console.WriteLine("3. SALIR")
            Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
            opcion_menu_principal = Console.ReadLine()
            Select Case opcion_menu_principal
                Case "1"
                    precio_neto(nombre_empresa)
                Case "2"
                    Dim opcion_menu_sueldo, opcion_indemnizacion As String
                    Console.WriteLine("EL SALARIO ANUAL PREDETERMINADO ES DE 12,000.00 B/. ANUALES")
                    Console.WriteLine("INGRESE EL NOMBRE DEL EMPLEADO")
                    nombre_empleado = Console.ReadLine()
                    Dim salario_anual As Single = 12000.0
                    Dim salario_mensual As Single = 1000.0
                    Dim cantidad_meses, meses_pendientes, cantidad_años, trimestre_pendiente As Integer
                    Dim porcentaje_aumento, cantidad_aumento, salario_total, salario_pendiente, liquidacion, vacaciones, decimo, prima, indemnizacion As Single
                    While True
                        Console.WriteLine("INGRESE LA CANTIDAD DE MESES LABORADOS POR EL TRABAJADOR")
                        Dim entrada_cantidad_meses As String = Console.ReadLine()
                        If Integer.TryParse(entrada_cantidad_meses, cantidad_meses) AndAlso cantidad_meses > 0 Then
                            Exit While
                        Else
                            Console.WriteLine("ENTRADA INVALIDA! POR FAVOR INGRESE UNA CANTIDAD VALIDA")
                        End If
                    End While
                    cantidad_años = cantidad_meses / 12
                    If cantidad_años <= 3 Then
                        porcentaje_aumento = 0.03
                    ElseIf cantidad_años > 3 And cantidad_años <= 5 Then
                        porcentaje_aumento = 0.05
                    ElseIf cantidad_años > 5 And cantidad_años <= 10 Then
                        porcentaje_aumento = 0.07
                    ElseIf cantidad_años >= 10 Then
                        porcentaje_aumento = 0.1
                    End If
                    cantidad_aumento = porcentaje_aumento * salario_anual
                    salario_total = salario_anual + cantidad_aumento
                    meses_pendientes = cantidad_meses Mod 12
                    salario_pendiente = meses_pendientes * salario_mensual
                    Do While True
                        Console.WriteLine("QUE DESEA HACER?")
                        Console.WriteLine("1. CALCULO DE SUELDO")
                        Console.WriteLine("2. CALCULO DE LIQUIDACION")
                        Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
                        opcion_menu_sueldo = Console.ReadLine()
                        Select Case opcion_menu_sueldo
                            Case "1"
                                Console.WriteLine(nombre_empresa)
                                Console.WriteLine(nombre_empleado)
                                Console.WriteLine($"EL SALARIO ANUAL ES DE: {salario_anual.ToString("F2")}")
                                Console.WriteLine($"LA CANTIDAD DE AÑOS TRABAJADOS ES DE: {cantidad_años}")
                                Console.WriteLine($"EL AUMENTO EQUIVALE A: {cantidad_aumento.ToString("F2")}")
                                Console.WriteLine($"SALARIO ANUAL TOTAL: {salario_total.ToString("F2")}")
                                Console.WriteLine("Presione cualquier tecla para continuar")
                                Console.ReadKey()
                                Exit Do
                            Case "2"
                                Console.WriteLine(nombre_empresa)
                                Console.WriteLine(nombre_empleado)
                                vacaciones = cantidad_años * salario_mensual
                                trimestre_pendiente = (meses_pendientes / 3)
                                decimo = (cantidad_años * salario_mensual) + (trimestre_pendiente / (salario_mensual / 3))
                                prima = (((salario_mensual * cantidad_años) * 13) / 12) / 4.333
                                Do While True
                                    Console.WriteLine("EXISTE INDEMNIZACION")
                                    Console.WriteLine("1. SI")
                                    Console.WriteLine("2. NO")
                                    Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
                                    opcion_indemnizacion = Console.ReadLine()
                                    Select Case opcion_indemnizacion
                                        Case "1"
                                            indemnizacion = (salario_mensual / 4.333) * (3.4 * cantidad_años)
                                            Exit Do
                                        Case "2"
                                            indemnizacion = 0
                                            Exit Do
                                        Case Else
                                            Console.WriteLine("SELECCION INVALIDA! POR FAVOR INGRESE UNA OPCION VALIDA")
                                    End Select
                                Loop
                                liquidacion = salario_pendiente + vacaciones + decimo + prima + indemnizacion
                                Console.WriteLine($"TOTAL DE SALARIO PENDIENTE: {salario_pendiente.ToString("F2")}")
                                Console.WriteLine($"TOTAL DE VACACIONES: {vacaciones.ToString("F2")}")
                                Console.WriteLine($"TOTAL DE DECIMO TERCER MES: {decimo.ToString("F2")}")
                                Console.WriteLine($"TOTAL DE PRIMA DE ANTIGUEDAD: {prima.ToString("F2")}")
                                Console.WriteLine($"TOTAL DE INDEMNIZACION: {indemnizacion.ToString("F2")}")
                                Console.WriteLine($"TOTAL DE LIQUIDACION: {liquidacion.ToString("F2")}")
                                Console.WriteLine("Presione cualquier tecla para continuar")
                                Console.ReadKey()
                                Exit Do
                            Case Else
                                Console.WriteLine("SELECCION INVALIDA! POR FAVOR INGRESE UNA OPCION VALIDA")
                        End Select
                    Loop
                Case "3"
                    Environment.Exit(0)
                Case Else
                    Console.WriteLine("SELECCION INVALIDA! POR FAVOR INGRESE UNA OPCION VALIDA")
            End Select
            Console.WriteLine("******************************************************************")
        Loop
    End Sub
End Module
