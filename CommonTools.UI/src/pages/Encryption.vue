<template>
  <div class="row">
      <ul class="nav nav-tabs">
            <li class="active">
                <a href="#rsa" data-toggle="tab">
                    RSA Key转换
                </a>
            </li>
            <li>
                <a href="#other" data-toggle="tab">
                    其他
                </a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="rsa">
                <rsakeyconvert></rsakeyconvert>
            </div>
            <div class="tab-pane fade in" id="other">
            </div>
        </div>
      
  </div>
</template>
<script>
import RSAKeyConvert from "@/components/encryption/RSAKeyConvert";

export default {
  name: "encryption",
  components: {
    rsakeyconvert: RSAKeyConvert
  }
};
</script>
