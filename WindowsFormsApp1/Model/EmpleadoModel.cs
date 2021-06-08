using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Poco;

namespace WindowsFormsApp1.Model
{
    class EmpleadoModel
    {
        private Empleado[] empleado;
        public void Add(Empleado vpn)
        {
            if (empleado == null)
            {
                empleado = new Empleado[1];
                empleado[0] = vpn;
                return;

            }
            Empleado[] temp = new Empleado[empleado.Length + 1];
            Array.Copy(empleado, temp, empleado.Length);
            temp[temp.Length - 1] = vpn;

            empleado = temp;
        }

        public Empleado[] GetAll()
        {
            return empleado;
        }

        public void Remove(int index)
        {
            if (index < 0)
            {
                return;
            }
            if (empleado == null)
            {
                return;
            }
            if (index >= empleado.Length)
            {
                throw new IndexOutOfRangeException($"El index {index} esta fuera del rango");
            }
            if (index == 0 && empleado.Length == 1)
            {
                empleado = null;
                return;
            }

            Empleado[] tmp = new Empleado[empleado.Length - 1];
            if (index == 0)
            {
                Array.Copy(empleado, index + 1, tmp, 0, tmp.Length);
                empleado = tmp;
                return;
            }
            if (index == empleado.Length - 1)
            {
                Array.Copy(empleado, 0, tmp, 0, tmp.Length);
                empleado = tmp;
                return;
            }

            Array.Copy(empleado, 0, tmp, 0, index);
            Array.Copy(empleado, index + 1, tmp, index, (tmp.Length - index - 1));
        }
    }
}
