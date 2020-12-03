import pymysql
from Clase_usuario import usuario

def conectar():
    try:
        conn = pymysql.connect(host='localhost', user='root', password='', db='Mobike')
    except:
        print("error conexion")
    return conn

def insertar(usuario):
    conexion= conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "INSERT INTO usuario (rut, nombre, email, direccion, trabaja_comuna, cuenta_bancaria, contraseña) VALUES (%s,%s,%s,%s,%s,%s,%s);"
            #llamar el execute con distintos datos
            cursor.execute(consulta,(usuario.rut, usuario.nombre, usuario.email, usuario.direccion, usuario.trabaja_comuna, usuario.contraseña, usuario.contraseña))
        conexion.commit()
    except (pymysql.err.OperationalError, pymysql.err.InternalError) as ex:
        print("error insertar", ex)
        conexion.close


def login(usuario):
    conexion = conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "SELECT rut, nombre, email, direccion, trabaja_comuna, cuenta_bancaria, contraseña FROM usuario where rut = %s and contraseña= %s"
            #Podemos ejecutar varios query
            cursor.execute(consulta,(usuario.nombre,usuario.email, usuario.direccion, usuario.trabaja_comuna, usuario.cuenta_bancaria, usuario.rut, usuario.contraseña))
    except (pymysql.err.OperationalError,pymysql.err.InternalError) as e:
        print("Error de SQL:",e)
    conexion.close() 

def eliminar(aux_rut):
    conexion = conectar()
    try:
        with conexion.cursor() as cursor:
            consulta = "DELETE FROM usuario where rut = %s;"
            #Podemos ejecutar varios query
            cursor.execute(consulta,(aux_rut))
        conexion.commit()
    except (pymysql.err.OperationalError,pymysql.err.InternalError) as e:
        print("Error de SQL:",e)
    conexion.close()