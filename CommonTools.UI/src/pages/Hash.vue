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
      <div class="row">
          <button type="button" class="btn btn-primary">MD5</button>
          <div class="btn-group">
            <button type="button" class="btn btn-info" v-on:click="sha('SHA-1')">SHA-1</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA-224')">SHA-224</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA3-224')">SHA3-224</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA-256')">SHA-256</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA3-256')">SHA3-256</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA-384')">SHA-384</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA3-384')">SHA3-384</button>
            <button type="button" class="btn btn-warning" v-on:click="sha('SHA-512')">SHA-512</button>
            <button type="button" class="btn btn-info" v-on:click="sha('SHA3-512')">SHA3-512</button>
        </div>
      </div>
  </div>
  
</template>
<script>
import jsSha from 'jssha'
export default {
  name:'hash',
  data(){
      return {
          plaintext:'',
          hashtext:''
      }
  },
    methods:{
        sha(hashtype){
            var outputtype='HEX';
            var shaobj = new jsSha(hashtype,"TEXT");
            shaobj.update(this.plaintext);
            this.hashtext = shaobj.getHash(outputtype)
        }
    }
}
</script>
