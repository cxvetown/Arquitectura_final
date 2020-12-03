import pymysql
from Clase_arriendo import arriendo

def conectar():
    try:
        conn = pymysql.connect(host='localhost', user='root', password='', db='Mobike')
    except:
        print("error conexion")
    return conn

def insertar(arriendo):
    conexion= conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "INSERT INTO arriendo (codigo_arriendo, rut_cliente) VALUES (%s,%s);"
            #llamar el execute con distintos datos
            cursor.execute(consulta,(arriendo.codigo_arriendo, arriendo.rut_cliente))
        conexion.commit()
    except (pymysql.err.OperationalError, pymysql.err.InternalError) as ex:
        print("error insertar", ex)
        conexion.close