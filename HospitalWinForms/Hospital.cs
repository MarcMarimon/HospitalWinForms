using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalWinForms
{
    public class Hospital
    {
        private List<Medico> medicos;
        private List<Paciente> pacientes;
        private List<PersonalAuxiliar> personalAuxiliar;

        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public List<PersonalAuxiliar> PersonalAuxiliar { get => personalAuxiliar; set => personalAuxiliar = value; }

        public Hospital()
        {
            Medicos = new List<Medico>();
            Pacientes = new List<Paciente>();
            PersonalAuxiliar = new List<PersonalAuxiliar>();
        }

        public void CrearMedico(string nombre, string apellido)
        {
            if (!EsNombreApellidoValido(nombre) || !EsNombreApellidoValido(apellido))
                throw new ArgumentException("Nombre o apellido no válido.");

            if (Medicos.Exists(m => m.Nombre == nombre && m.Apellido == apellido))
                throw new ArgumentException("Ya existe un médico con ese nombre y apellido.");

            Medico nuevoMedico = new Medico(nombre, apellido);
            Medicos.Add(nuevoMedico);
        }

        public void CrearPaciente(string nombre, string apellido)
        {
            if (!EsNombreApellidoValido(nombre) || !EsNombreApellidoValido(apellido))
                throw new ArgumentException("Nombre o apellido no válido.");

            if (Pacientes.Exists(p => p.Nombre == nombre && p.Apellido == apellido))
                throw new ArgumentException("Ya existe un paciente con ese nombre y apellido.");

            Paciente nuevoPaciente = new Paciente(nombre, apellido);
            Pacientes.Add(nuevoPaciente);
        }

        public void CrearPersonalAuxiliar(string nombre, string apellido, Departamento departamento)
        {
            if (!EsNombreApellidoValido(nombre) || !EsNombreApellidoValido(apellido))
                throw new ArgumentException("Nombre o apellido no válido.");

            if (PersonalAuxiliar.Exists(p => p.Nombre == nombre && p.Apellido == apellido))
                throw new ArgumentException("Ya existe un personal auxiliar con ese nombre y apellido.");

            PersonalAuxiliar nuevoPersonalAuxiliar = new PersonalAuxiliar(nombre, apellido, departamento);
            PersonalAuxiliar.Add(nuevoPersonalAuxiliar);
        }

        public void AsignarPacienteAMedico(Paciente paciente, Medico medico)
        {
            if (medico.Pacientes.Contains(paciente))
                throw new ArgumentException("Este paciente ya está siendo atendido por este médico.");
            else
                medico.AsignarPaciente(paciente);
        }

        public void AsignarMedicoAPaciente(Medico medico, Paciente paciente)
        {
            if (paciente.Medicos.Contains(medico))
                throw new ArgumentException("Este médico ya está atendiendo a este paciente.");
            else
                paciente.AsignarMedico(medico);
        }

        public List<Paciente> VerPacientesDeMedico(Medico medico)
        {
            return medico.Pacientes;
        }

        public List<Medico> VerMedicosDePaciente(Paciente paciente)
        {
            return paciente.Medicos;
        }

        public void DesasignarPacienteDeMedico(Medico medico, Paciente paciente)
        {
            medico.DesasignarPaciente(paciente);
        }

        public void DesasignarMedicoDePaciente(Paciente paciente, Medico medico)
        {
            paciente.DesasignarMedico(medico);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.AddRange(Medicos);
            empleados.AddRange(PersonalAuxiliar);
            return empleados;
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.AddRange(Medicos);
            personas.AddRange(Pacientes);
            personas.AddRange(PersonalAuxiliar);
            return personas;
        }

        public void EliminarMedico(Medico medico)
        {
            Medicos.Remove(medico);
        }

        public void EliminarPaciente(Paciente paciente)
        {
            Pacientes.Remove(paciente);
        }

        public void EliminarPersonalAuxiliar(PersonalAuxiliar personal)
        {
            PersonalAuxiliar.Remove(personal);
        }

        private bool EsNombreApellidoValido(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }
    }
}

