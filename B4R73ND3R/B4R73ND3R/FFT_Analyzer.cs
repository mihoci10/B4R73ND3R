using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.IntegralTransforms;

namespace B4R73ND3R
{
    class FFT_Analyzer
    {

        public void doFFT(List<float> inputArr)
        {
            Complex[] samples = new Complex[inputArr.Count];

            for (int i=0;i<samples.Length;i++)
            {
                samples[i] = new Complex(inputArr[i],0);
            }

            Fourier.Forward(samples,FourierOptions.NoScaling);


        }
    }
}
