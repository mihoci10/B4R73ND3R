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

        public void doFFT(List<float> inputArr, double sampleRate)
        {
            double[] magnitudes = new double[inputArr.Count];
            Complex[] samples = new Complex[inputArr.Count];

            for (int i=0;i<samples.Length;i++)
            {
                samples[i] = new Complex(inputArr[i],0);
            }

            Fourier.Forward(samples,FourierOptions.NoScaling);

            for (int i = 0; i < samples.Length; i++)
            {
                magnitudes[i] = Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) + Math.Pow(samples[i].Imaginary, 2)));
            }

            double hertzPerSample = sampleRate / magnitudes.Length;

            Console.WriteLine("Hertz per sample: "+hertzPerSample);
            
            double peakFrequency = Array.IndexOf(magnitudes, magnitudes.Max()) * hertzPerSample;

            Console.WriteLine("Peak frequency: "+peakFrequency+" with magnitude of "+magnitudes.Max());
        }
    }
}
