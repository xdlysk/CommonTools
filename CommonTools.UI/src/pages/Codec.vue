<template>
  <div class="row">
      <ul class="nav nav-tabs">
            <li class="active">
                <a href="#base64" data-toggle="tab">
                    Base64编解码
                </a>
            </li>
            <li>
                <a href="#base64image" data-toggle="tab">
                    Base64图片转换
                </a>
            </li>
            <li>
                <a href="#uriencode" data-toggle="tab">
                    URIEncode
                </a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="base64">
                <base64fromto></base64fromto>
            </div>
            <div class="tab-pane fade in" id="base64image">
                <base64image></base64image>
            </div>
            <div class="tab-pane fade in" id="uriencode">
                <uricodec></uricodec>
            </div>
        </div>
      
  </div>
</template>
<script>
import Base64Image from "@/components/codec/Base64Image";
import Base64FromTo from "@/components/codec/Base64FromTo";
import URICodec from "@/components/codec/URICodec";

export default {
  name: "codec",
  components: {
    base64image: Base64Image,
    base64fromto:Base64FromTo,
    uricodec:URICodec
  }
};
</script>
