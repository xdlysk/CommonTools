<template>
  <div>
      <div class="row">
        <div class="col-md-6">
                <span>原文</span>
                <textarea class="form-control" rows="14" v-model="plaintext"></textarea>
            </div>
      <div class="col-md-6">
          <span>Code</span>
          <textarea class="form-control" rows="14" v-model="hashtext"></textarea>
            </div>
      </div>
      <div style="padding:10px">
          <div class="form-inline">
              <div class="input-group">
                    <span class="input-group-addon">
                        <input type="checkbox" v-model="enableHmac">HMAC</span>
                    <input type="text" class="form-control" v-show="enableHmac" v-model="hmackey" placeholder="HMACKey">
                </div>
          <button type="button" class="btn btn-primary" v-on:click="sha('MD5')">MD5</button>
          <div class="btn-group">
            <button type="button" class="btn btn-info" v-on:click="sha('SHA1')">SHA-1</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA3')">SHA-3</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA224')">SHA-224</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA256')">SHA-256</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA384')">SHA-384</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA512')">SHA-512</button>
        </div>
    </div>
      </div>      
  </div>
  
</template>
<script>
import crypto from 'crypto-js'
export default {
  name:'hash',
  data(){
      return {
          plaintext:'',
          hashtext:'',
          hmackey:'',
          enableHmac:false
      }
  },
    methods:{
        sha(hashtype){
            if(this.enableHmac){
                this.hashtext = crypto['Hmac'+hashtype](this.plaintext,this.hmackey).toString();
            }else{
                this.hashtext = crypto[hashtype](this.plaintext).toString();
            }
            
        }
    }
}
</script>
