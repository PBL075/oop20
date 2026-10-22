using System;

namespace amogus
{
    class Role
    {
        public Rolul rolul;

        public Role(Rolul rolul)
        {
            this.rolul = rolul;

        }
        public void Afisare()
        {
            Console.WriteLine("Tu ai rolul de "+ rolul);
        }        
    }
}