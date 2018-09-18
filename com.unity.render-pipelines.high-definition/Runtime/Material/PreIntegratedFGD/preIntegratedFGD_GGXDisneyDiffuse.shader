Shader "Hidden/HDRenderPipeline/preIntegratedFGD_GGXDisneyDiffuse"
{
    SubShader
    {
        Tags{ "RenderPipeline" = "HDRenderPipeline" }
        Pass
        {
            ZTest Always Cull Off ZWrite Off

            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag
            #pragma target 4.5
            #pragma only_renderers d3d11 ps4 xboxone vulkan metal switch

            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/ImageBasedLighting.hlsl"
            #include "../../ShaderVariables.hlsl"
            #include "PreIntegratedFGD.cs.hlsl"

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 texCoord   : TEXCOORD0;
            };

            Varyings Vert(Attributes input)
            {
                Varyings output;

                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);
                output.texCoord   = GetFullScreenTriangleTexCoord(input.vertexID);

                return output;
            }

            float4 Frag(Varyings input) : SV_Target
            {
                // We want the LUT to contain the entire [0, 1] range, without losing half a texel at each side.
                float2 coordLUT = RemapHalfTexelCoordTo01(input.texCoord, FGDTEXTURE_RESOLUTION);

                // These coordinate sampling must match the decoding in GetPreIntegratedDFG in Lit.hlsl,
                // i.e here we use perceptualRoughness, must be the same in shader
            #if 0
                float NdotV = cos(HALF_PI * coordLUT.x);
            #else
                float NdotV = coordLUT.x;
            #endif
                float perceptualRoughness = coordLUT.y;

                // Pre integrate GGX with smithJoint visibility as well as DisneyDiffuse
                float4 preFGD = IntegrateGGXAndDisneyDiffuseFGD(NdotV, PerceptualRoughnessToRoughness(perceptualRoughness));

                return float4(preFGD.xyz, 1.0);
            }

            ENDHLSL
        }
    }
    Fallback Off
}
