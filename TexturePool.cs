using Gist;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Texture2DArraySimplified {

    public class TexturePool : System.IDisposable {
        public const int MIN_CAPACITY = 4;

        protected Texture2DArray array;
        protected Texture2D[] textures;
        protected List<int> unusedIndices;

        public TexturePool() {
            Reset();
        }

        #region IDisposable
        public void Dispose() {
            Reset();
        }
        #endregion

        protected virtual void Resize(int nextSize) {

        }
        protected virtual void Reset() {
            if (array != null) {
                ObjectDestructor.Destroy(array);
                array = null;
            }
            textures = new Texture2D[0];
            unusedIndices = new List<int>();
        }
    }
}
