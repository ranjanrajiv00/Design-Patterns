﻿namespace FactoryMethod.Autos
{
    public interface IAuto
    {
        string ModelName { get; set; }

        void Start();

        void Stop();
    }
}