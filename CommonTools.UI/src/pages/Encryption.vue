<template>
  <div class="row">
      <rsakeyconvert></rsakeyconvert>
  </div>
</template>
<script>
import RSAKeyConvert from '@/components/encryption/RSAKeyConvert';

export default {
  name:'encryption',
  components:{
      rsakeyconvert:RSAKeyConvert
  }
}
</script>
