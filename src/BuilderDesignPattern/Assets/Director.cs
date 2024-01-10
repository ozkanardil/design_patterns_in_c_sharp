using BuilderDesignPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Assets
{
    internal class Director
    {
        IBuilder? _builder;

        public void Construct(IBuilder builder)
        {
            _builder = builder;
            _builder.SetBrand();
            _builder.AddRam();
            _builder.AddCpu();
            _builder.AddGraphicCard();
            _builder.EndOperations();
        }
    }
}
