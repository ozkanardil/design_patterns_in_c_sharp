using BuilderDesignPattern.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder
{
    public interface IBuilder
    {
        void SetBrand();
        void AddRam();
        void AddCpu();
        void AddGraphicCard();
        void EndOperations();
        Product GetComputer();
    }
}
