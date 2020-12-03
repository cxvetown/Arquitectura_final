#importar clases y mantenedores
import Clase_usuario, Clase_arriendo, Clase_devolucion, Clase_reporte, Clase_reporte_especifico
import pymysql
import Mantenedor_usuario, Mantenedor_arriendo, Mantenedor_devolucion, Mantenedor_reporte
#importar archivos necesarios
from flask import Flask, render_template, request, flash, redirect, url_for 

app = Flask(__name__)

#ruta principal
@app.route('/')

#renderizado de paginas

@app.route('/Index')
def Index():
    return render_template('Index.html')

@app.route('/administrador')
def administrador():
    datos = Mantenedor_reporte.consultar()
    return render_template('administrador.html', reporte_add = datos)

@app.route('/Arriendo')
def Arriendo():
    return render_template('Arriendo.html')

@app.route('/funcionario')
def funcionario():
    return render_template('funcionario.html')

@app.route('/generar_reporte')
def generar_reporte():
    return render_template('generar_reporte.html')

@app.route('/login_admin')
def login_admin():
    return render_template('login_admin.html')

@app.route('/login_funcionario')
def login_funcionario():
    return render_template('login_funcionario.html')

@app.route('/login')
def login():
    return render_template('login.html')

@app.route('/proceso_arriendo')
def proceso_arriendo():
    return render_template('proceso_arriendo.html')

@app.route('/proceso_devolucion')
def proceso_devolucion():
    return render_template('proceso_devolucion.html')

@app.route('/registrarse')
def registrarse():
    return render_template('registrarse.html')

@app.route('/reportes_admin')
def reportes_admin():
    return render_template('reportes_admin.html')

#fin renderizado

#registrarse
@app.route('/registrar_usuario', methods=['POST'])
def registrar_usuario():
    #insertar
    if request.method=='POST':
        try:
            auxbotonInsertar = request.form['Aceptar_btn']
            if auxbotonInsertar == 'Aceptar':
                auxrut = request.form['txt_rut'] 
                auxNombre = request.form['txt_nombre']
                auxemail = request.form['txt_email'] 
                auxdireccion = request.form['txt_direccion']
                auxtrabaja = request.form['trabaja_cbo']
                auxcuenta_bancaria = request.form['txt_bancaria']
                auxpass = request.form['passwd']

                aux_add_user = Clase_usuario.usuario(auxrut, auxNombre, auxemail, auxdireccion, auxtrabaja, auxcuenta_bancaria, auxpass)
                Mantenedor_usuario.insertar(aux_add_user)
                flash('datos guardados')  

        except:
            print('Error')
        return redirect(url_for('Index'))

def conectar():
    try:
        conn = pymysql.connect(host='localhost', user='root', password='', db='Mobike')
    except:
        print("error conexion")
    return conn

#login usuario
@app.route('/login_user', methods=['POST'])
def login_user():
    conexion = conectar()
    cursor = conexion.cursor()
    if request.method=='POST':
        user = request.form['user_txt']
        password = request.form['pass_txt']
        cursor.execute("SELECT * FROM usuario WHERE rut ='" +user+"' and contraseña ='"+password+"';")
        cursor.fetchall()
        count = cursor.rowcount
        if count==1:
            return redirect (url_for("Index"))
        else:
            return redirect (url_for('login'))
        conexion.commit()
        conexion.close()

#login admin
@app.route('/login_admin_mantenedor', methods=['POST'])
def login_admin_mantenedor():
    conexion = conectar()
    cursor = conexion.cursor()
    if request.method=='POST':
        user = request.form['user_txt']
        password = request.form['pass_txt']
        cursor.execute("SELECT * FROM administrador WHERE rut ='" +user+"' and contraseña ='"+password+"';")
        cursor.fetchall()
        count = cursor.rowcount
        if count==1:
            return redirect (url_for("administrador"))
        else:
            return redirect (url_for('login_admin'))
        conexion.commit()
        conexion.close()

#login funcionario
@app.route('/login_funcionario_mantenedor', methods=['POST'])
def login_funcionario_mantenedor():
    conexion = conectar()
    cursor = conexion.cursor()
    if request.method=='POST':
        user = request.form['user_txt']
        password = request.form['pass_txt']
        cursor.execute("SELECT * FROM funcionario WHERE rut ='" +user+"' and contraseña ='"+password+"';")
        cursor.fetchall()
        count = cursor.rowcount
        if count==1:
            return redirect (url_for("funcionario"))
        else:
            return redirect (url_for('login_funcionario'))
        conexion.commit()
        conexion.close()

#insertar arriendo
@app.route('/arriendo_mantenedor', methods=['POST'])
def arriendo_mantenedor():
    #insertar
    if request.method=='POST':
        try:
            auxbotonInsertar = request.form['Aceptar_btn']
            if auxbotonInsertar == 'Aceptar':
                auxcodigo = request.form['txt_codigo'] 
                auxrut = request.form['rut_txt']
                
                aux_arriendo = Clase_arriendo.arriendo(auxcodigo, auxrut)
                Mantenedor_arriendo.insertar(aux_arriendo)
                flash('datos guardados')  

        except:
            print('Error')
        return redirect(url_for('Arriendo'))

#insertar devolucion
@app.route('/devolucion_mantenedor', methods=['POST'])
def devolucion_mantenedor():
    #insertar
    if request.method=='POST':
        try:
            auxbotonInsertar = request.form['Aceptar_btn']
            if auxbotonInsertar == 'Aceptar':
                auxrut = request.form['txt_rut'] 
                auxvalor = request.form['txt_valor_total']
                
                aux_devolucion = Clase_devolucion.devolucion(auxrut, auxvalor)
                Mantenedor_devolucion.insertar(aux_devolucion)
                flash('datos guardados')  

        except:
            print('Error')
        return redirect(url_for('Arriendo'))


#ingresar reporte
@app.route('/reporte_mantenedor', methods=['POST'])
def reporte_mantenedor():
    #insertar
    if request.method=='POST':
        try:
            auxbotonInsertar = request.form['Aceptar_btn']
            if auxbotonInsertar == 'Aceptar':
                auxcodigo = request.form['cod_reporte'] 
                auxNombre = request.form['nombre_reporte']
                auxrut = request.form['rut_txt'] 
                auxdescripcion = request.form['txt_descripcion']

                aux_add_reporte = Clase_reporte.reporte(auxcodigo, auxNombre, auxrut, auxdescripcion)
                Mantenedor_reporte.insertar(aux_add_reporte)

                flash('datos guardados')  

        except:
            print('Error')
        return redirect(url_for('generar_reporte'))

#eliminar
@app.route('/mantenedor_reporte_1', methods=['POST'])
def mantenedor_reporte_1():
 #eliminar  
        try:
            auxBotonEliminar = request.form['Eliminar_btn']
            if auxBotonEliminar == 'Eliminar usuario':
                aux_codigo = request.form['rut_txt']
                Mantenedor_reporte.eliminar(aux_codigo)
                Mantenedor_usuario.eliminar(aux_codigo)
                print('datos Eliminados')
                #flash('datos Eliminados')
        except:
            print('datos No Eliminados')
            #flash('datos No Eliminados') 
        return redirect(url_for('administrador'))

if __name__ == '__main__':
    app.run(port = 3001, debug = True)