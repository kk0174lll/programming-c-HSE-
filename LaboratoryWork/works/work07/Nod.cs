﻿

namespace LaboratoryWork.works.work07
{
    class Nod<T>
    {
        public T value;
        public Nod<T> next;
        public Nod<T> prew;

        public Nod(T value)
        {
            this.value = value;
        }
    }
}
