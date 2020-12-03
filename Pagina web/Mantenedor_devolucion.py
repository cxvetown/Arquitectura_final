import pymysql
from Clase_devolucion import devolucion

def conectar():
    try:
        conn = pymysql.connect(host='localhost', user='root', password='', db='Mobike')
    except:
        print("error conexion")
    return conn

def insertar(devolucion):
    conexion= conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "INSERT INTO devolucion (rut, valor_total) VALUES (%s,%s);"
            #llamar el execute con distintos datos
            cursor.execute(consulta,(devolucion.rut, devolucion.valor_total))
        conexion.commit()
    except (pymysql.err.OperationalError, pymysql.err.InternalError) as ex:
        print("error insertar", ex)
        conexion.close