﻿namespace Exam
{
    public interface IProduct
    {
        string Name { get; set; }

        decimal Price { get; set; }

        void Present();
    }
}
