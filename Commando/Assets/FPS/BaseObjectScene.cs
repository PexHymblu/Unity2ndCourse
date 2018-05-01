using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS

{
    public abstract class BaseObjectScene : MonoBehaviour
    {
        protected int _layer;
        protected Color _color;
        protected Material _material;
        protected Transform _myTransform;
        protected Vector3 _position;
        protected Quaternion _rotation;
        protected Vector3 _scale;
        protected GameObject _instanceObject;
        protected Rigidbody _rigidbody;
        protected string _name;
        protected bool _isVisible;

        public int Layer
        {
            get
            {
                return _layer;
            }

            set
            {
                _layer = value;
                if (gameObject)
                {
                    gameObject.layer = _layer;
                }
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
                if (_material != null)
                {
                    _material.color = _color;
                }
                AskColor(GetTransform, _color);
            }
        }

        public Material Material
        {
            get
            {
                return _material;
            }            
        }

        protected Vector3 Position
        {
            get
            {
                if (_instanceObject != null)
                {
                    _position = GetTransform.position;
                }
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        protected virtual void Awake()
        {
            _instanceObject = gameObject;
            _name = _instanceObject.name;
            if (GetComponent<Renderer>())
            {
                _material = GetComponent<Renderer>().material;
            }
            _rigidbody = _instanceObject.GetComponent<Rigidbody>();
            _myTransform = _instanceObject.transform;
        }

        private void SetLayers(Transform objTransform, int layer)
        {

        }


    }  
    
}