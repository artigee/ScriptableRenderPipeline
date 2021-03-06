using UnityEngine.Experimental.Rendering.HDPipeline;

namespace UnityEditor.Experimental.Rendering.HDPipeline
{
    public class SerializedFrameSettings
    {
        public SerializedProperty root;

        public SerializedProperty enableShadow;
        public SerializedProperty enableContactShadow;
        public SerializedProperty enableSSR;
        public SerializedProperty enableSSAO;
        public SerializedProperty enableSubsurfaceScattering;
        public SerializedProperty enableTransmission;
        public SerializedProperty enableAtmosphericScattering;
        public SerializedProperty enableVolumetrics;
        public SerializedProperty enableReprojectionForVolumetrics;
        public SerializedProperty enableLightLayers;

        public SerializedProperty diffuseGlobalDimmer;
        public SerializedProperty specularGlobalDimmer;

        public SerializedProperty enableForwardRenderingOnly;
        public SerializedProperty enableDepthPrepassWithDeferredRendering;

        public SerializedProperty enableTransparentPrepass;
        public SerializedProperty enableMotionVectors;
        public SerializedProperty enableObjectMotionVectors;
        public SerializedProperty enableDecals;
        public SerializedProperty enableRoughRefraction;
        public SerializedProperty enableTransparentPostpass;
        public SerializedProperty enableDistortion;
        public SerializedProperty enablePostprocess;

        public SerializedProperty enableStereo;
        public SerializedProperty xrGraphicsConfig;
        public SerializedProperty enableAsyncCompute;

        public SerializedProperty enableOpaqueObjects;
        public SerializedProperty enableTransparentObjects;

        public SerializedProperty enableMSAA;

        public SerializedProperty enableShadowMask;

        public SerializedLightLoopSettings lightLoopSettings;


        public SerializedFrameSettings(SerializedProperty root)
        {
            this.root = root;

            enableShadow = root.Find((FrameSettings d) => d.enableShadow);
            enableContactShadow = root.Find((FrameSettings d) => d.enableContactShadows);
            enableSSR = root.Find((FrameSettings d) => d.enableSSR);
            enableSSAO = root.Find((FrameSettings d) => d.enableSSAO);
            enableSubsurfaceScattering = root.Find((FrameSettings d) => d.enableSubsurfaceScattering);
            enableTransmission = root.Find((FrameSettings d) => d.enableTransmission);
            enableAtmosphericScattering = root.Find((FrameSettings d) => d.enableAtmosphericScattering);
            enableVolumetrics = root.Find((FrameSettings d) => d.enableVolumetrics);
            enableReprojectionForVolumetrics = root.Find((FrameSettings d) => d.enableReprojectionForVolumetrics);
            enableLightLayers = root.Find((FrameSettings d) => d.enableLightLayers);
            diffuseGlobalDimmer = root.Find((FrameSettings d) => d.diffuseGlobalDimmer);
            specularGlobalDimmer = root.Find((FrameSettings d) => d.specularGlobalDimmer);
            enableForwardRenderingOnly = root.Find((FrameSettings d) => d.enableForwardRenderingOnly);
            enableDepthPrepassWithDeferredRendering = root.Find((FrameSettings d) => d.enableDepthPrepassWithDeferredRendering);
            enableTransparentPrepass = root.Find((FrameSettings d) => d.enableTransparentPrepass);
            enableMotionVectors = root.Find((FrameSettings d) => d.enableMotionVectors);
            enableObjectMotionVectors = root.Find((FrameSettings d) => d.enableObjectMotionVectors);
            enableDecals = root.Find((FrameSettings d) => d.enableDecals);
            enableRoughRefraction = root.Find((FrameSettings d) => d.enableRoughRefraction);
            enableTransparentPostpass = root.Find((FrameSettings d) => d.enableTransparentPostpass);
            enableDistortion = root.Find((FrameSettings d) => d.enableDistortion);
            enablePostprocess = root.Find((FrameSettings d) => d.enablePostprocess);
            enableStereo = root.Find((FrameSettings d) => d.enableStereo);
            xrGraphicsConfig = root.Find((FrameSettings d) => d.xrGraphicsConfig);
            enableAsyncCompute = root.Find((FrameSettings d) => d.enableAsyncCompute);
            enableOpaqueObjects = root.Find((FrameSettings d) => d.enableOpaqueObjects);
            enableTransparentObjects = root.Find((FrameSettings d) => d.enableTransparentObjects);
            enableMSAA = root.Find((FrameSettings d) => d.enableMSAA);
            enableShadowMask = root.Find((FrameSettings d) => d.enableShadowMask);

            lightLoopSettings = new SerializedLightLoopSettings(root.Find((FrameSettings d) => d.lightLoopSettings));
        }
    }
}
