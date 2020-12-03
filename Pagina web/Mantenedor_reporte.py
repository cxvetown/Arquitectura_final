import pymysql
from Clase_reporte import reporte
from Clase_reporte_especifico import reporte_especifico

def conectar():
    try:
        conn = pymysql.connect(host='localhost', user='root', password='', db='Mobike')
    except:
        print("error conexion")
    return conn

def insertar(reporte):
    conexion= conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "INSERT INTO reporte (codigo_reporte, nombre_usuario, rut_usuario, descripcion) VALUES (%s,%s,%s,%s);"
            #llamar el execute con distintos datos
            cursor.execute(consulta,(reporte.codigo_reporte, reporte.nombre_usuario, reporte.rut_usuario, reporte.descripcion))
        conexion.commit()
    except (pymysql.err.OperationalError, pymysql.err.InternalError) as ex:
        print("error insertar", ex)
        conexion.close

def consultar():
    conexion= conectar()
    try:
        with conexion.cursor() as cursor:
            cursor.execute("SELECT codigo_reporte, nombre_usuario, rut_usuario, descripcion FROM reporte;")
            #llamar el execute con distintos datos
            auxreporte = cursor.fetchall()

            for reporte in auxreporte:
                print(reporte)
            return auxreporte
    except (pymysql.err.OperationalError, pymysql.err.InternalError) as ex:
        print("error insertar", ex)
        conexion.close

def eliminar(aux_reporte):
    conexion = conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "DELETE FROM reporte where rut_usuario = %s;"
            #Podemos ejecutar varios query
            cursor.execute(consulta,(aux_reporte))
        conexion.commit()
    except (pymysql.err.OperationalError,pymysql.err.InternalError) as e:
        print("Error de SQL:",e)
    conexion.close()