using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCharts.Shared.Structs
{
    /// <summary>
    /// ColorEx
    /// </summary>
    public struct ColorEx
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorEx"/> struct.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        public ColorEx(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorEx"/> struct.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <param name="A">a.</param>
        public ColorEx(int R, int G, int B, int A)
        {
            this.A = A;
            this.R = R;
            this.G = G;
            this.B = B;
        }

        /// <summary>
        /// Gets or sets a.
        /// </summary>
        /// <value>
        /// a.
        /// </value>
        public int A { get; set; }

        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        /// <value>
        /// The r.
        /// </value>
        public int R { get; set; }

        /// <summary>
        /// Gets or sets the g.
        /// </summary>
        /// <value>
        /// The g.
        /// </value>
        public int G { get; set; }

        /// <summary>
        /// Gets or sets the b.
        /// </summary>
        /// <value>
        /// The b.
        /// </value>
        public int B { get; set; }
    }
}
