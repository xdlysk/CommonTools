<template>
<div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">Base64</h3>
    </div>
    <div class="panel-body">
        <div class="form-group">
            <div class="col-md-5">
                <span>原文</span>
                <textarea class="form-control" rows="14" v-model="plaintext"></textarea>
            </div>
            <div class="col-md-2">
                <div class="btn-group-vertical">
                <button type="button" class="btn btn-default" v-on:click="plaintocode">EncodeURI</button>
                <button type="button" class="btn btn-default" v-on:click="codetoplain">DecodeURI</button>
                <button type="button" class="btn btn-default" v-on:click="dcodetoplain">EncodeURIComponent</button>
                <button type="button" class="btn btn-default" v-on:click="dcodetoplain">DecodeURIComponent</button>
                </div>
            </div>
      <div class="col-md-5">
          <span>Code</span>
          <textarea class="form-control" rows="14" v-model="codetext"></textarea>
            </div>
      </div>      
        </div>
</div>
</template>
<script>
export default {
  name:'uricodec',
  data(){
      return {
          plaintext:'',
          codetext:''
      }
  },
  methods:{
      plaintocode(){
          this.codetext = encodeURI(this.plaintext);
      },
      codetoplain(){
          this.plaintext = decodeURI(this.codetext);
      },
      dplaintocode(){
          this.codetext = encodeURIComponent(this.plaintext);
      },
      dcodetoplain(){
          this.plaintext = decodeURIComponent(this.codetext);
      }
  }
}
</script>
