# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, específicamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser validado.

Para el ejercicio se pide

#### ✍ Parte 1
El código en un principio no aplicaba el principio SRP, ya que la clase "AppointmentService" se encargaba de verificar cada dato que se le proporcionaba previo a la creación de la cita, por lo que si se realizan cambios en los datos proporcionados, ya sea quitando o agregando información, ésta debería cambiar.
Se crearon las clases 'Patient' y 'Doctor', las cuales tendrán los datos de cada uno. Se verifica mediante un método dentro de cada clase que cada dato esté presente.
Esto significa que bajo ninguna circunstancia la clase 'AppointmentService' deberá cambiar.

#### 🧐 Parte 2
<table id="card">
    <tr>
        <td align="center" colspan="2">
            <b>Patient</b>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la información del paciente</p>
            <p>Verificar datos</p>
        </td>
        <td>
            <p>---</p>
        </td>
    </tr>
</table>

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <b>Doctor</b>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la información del doctor</p>
            <p>Verificar datos</p>
        </td>
        <td>
            <p>---</p>
        </td>
    </tr>
</table>

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <b>AppointmentService</b>
        </td>
    </tr>
    <tr>
        <td>
            <p>Crear una cita</p>
        </td>
        <td>
            <p>Patient</p>
            <p>Doctor</p>
        </td>
    </tr>
</table>

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

