using Gist;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Texture2DArraySimplified {

    public class Texture2DList : System.IDisposable {
        public Texture2DArray Data { get; protected set; }

        public int Width { get; protected set; }
        public int Height { get; protected set; } 
        public TextureFormat Format { get; protected set; }
        public bool Mipmap { get; protected set; }
        public bool Linear { get; protected set; }

        public Texture2DList(int width, int height, TextureFormat format, bool mipmap, bool linear) {
            this.Width = width;
            this.Height = height;
            this.Format = format;
            this.Mipmap = mipmap;
            this.Linear = linear;
        }
        public Texture2DList(Texture2D tex, bool linear) 
            : this(tex.width, tex.height, tex.format, tex.mipmapCount > 1, linear) { 


        }

        public void Dispose() {
            Release();
        }

        public void Release() {
            if (Data != null)
                ObjectDestructor.Destroy(Data);
        }
    }
}
