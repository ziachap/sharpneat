﻿using System;
using SharpNeat.BlackBox;

namespace SharpNeat.Tasks.Tests.PreyCapture
{
    internal class MockPreyCaptureAgent : IBlackBox<double>
    {
        readonly double[] _inputArr;
        readonly double[] _outputArr;

        #region Constructor

        public MockPreyCaptureAgent()
        {
            _inputArr = new double[14];
            this.Inputs = _inputArr;
            _outputArr = new double[4];
            this.Outputs = new VectorSegment<double>(_outputArr, 0, 4);
        }

        #endregion

        #region IBlackBox

        public int InputCount => 14;

        public int OutputCount => 4;

        public Memory<double> Inputs { get; }

        public IVector<double> Outputs { get; }

        public void Activate()
        {
        }

        public void Reset()
        {
            Array.Clear(_outputArr, 0, _outputArr.Length);
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// Releases both managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }

        #endregion
    }
}
