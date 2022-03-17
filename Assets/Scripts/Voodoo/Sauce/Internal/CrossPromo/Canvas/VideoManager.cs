using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Voodoo.Sauce.Internal.CrossPromo.Models;

namespace Voodoo.Sauce.Internal.CrossPromo.Canvas
{
	public class VideoManager
	{
		private readonly RawImage _003CContent_003Ek__BackingField;

		private readonly VideoPlayer _003CVideoPlayer_003Ek__BackingField;

		private readonly RenderTexture _renderTexture;

		public RawImage Content => null;

		public VideoPlayer VideoPlayer => null;

		public VideoManager(VideoPlayer video, RawImage content)
		{
		}

		public static AssetModel ChooseVideo()
		{
			return null;
		}

		public void PrepareVideo(AssetModel asset)
		{
		}

		public void StopVideo()
		{
		}

		private void ReleaseTexture()
		{
		}

		private void OnVideoComplete(VideoPlayer source)
		{
		}
	}
}
