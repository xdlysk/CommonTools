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
                <button type="button" class="btn btn-default" v-on:click="plaintobase64">原文转Base64</button>
                <button type="button" class="btn btn-default" v-on:click="base64toplain">Base64转原文</button>
                </div>
            </div>
      <div class="col-md-5">
          <span>Base64</span>
          <textarea class="form-control" rows="14" v-model="base64text"></textarea>
            </div>
      </div>      
        </div>
</div>
</template>
<script>
import Base64 from 'js-base64'

export default {
  name:'base64fromto',
  data(){
      return {
          plaintext:'',
          base64text:''
      }
  },
  methods:{
      plaintobase64(){
          if(this.plaintext!==''){
              this.base64text = Base64.Base64.encode(this.plaintext);
          }
      },
      base64toplain(){
          if(this.base64text!==''){
              this.plaintext = Base64.Base64.decode(this.base64text);
          }
      }
  }
}
</script>
