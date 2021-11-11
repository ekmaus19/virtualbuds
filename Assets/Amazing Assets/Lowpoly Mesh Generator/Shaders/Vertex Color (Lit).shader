Shader "Amazing Assets/Lowpoly Mesh Generator/Vertex Color (Lit)"
{
    Properties
    {
        _Glossiness ("Smoothness", Range(0,1)) = 0.0
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        half _Glossiness;
        half _Metallic;

        struct Input
        {
            float2 uv_MainTex;
            fixed4 color : COLOR;
        };                


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from vertex color
            o.Albedo = IN.color.rgb;

            // Metallic and smoothness come from slider variables
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = IN.color.a;
        }
        ENDCG
    }

    FallBack "Diffuse"
}
