<template>
  <div class="container">
   <div class="row">
      <div class="col-md-5">
          <textarea class="form-control" rows="8" v-model="origin"></textarea>
      </div>
      <div class="col-md-2">
          <div class="btn-group-vertical">
            <button type="button" class="btn btn-default" v-on:click="privatekeyjava2dotnet">Java PrivateKey 转 .NET</button>
            <button type="button" class="btn btn-default" v-on:click="publickeyjava2dotnet">Java PublicKey 转 .NET</button>
            <button type="button" class="btn btn-default" v-on:click="privatekeydotnet2java">.NET PrivateKey 转 Java</button>
            <button type="button" class="btn btn-default" v-on:click="publickeydotnet2java">.NET PublicKey 转 Java</button>
          </div>
      </div>
      <div class="col-md-5">
          <textarea class="form-control" rows="8" v-model="aftercalc"></textarea>
      </div>      
   </div>
   <div class="row">
       <button type="button" class="btn btn-warning" v-on:click="clearContent">清空</button>
   </div>
</div>
</template>
<script>
var requestOption={
    method:'POST',
    headers:{"Content-Type":"application/json;charset=utf-8"}
};
export default {
  name:'rsakeyconvert',
  data(){
      return {
          origin:"",
          aftercalc:""
      }
  },
  methods:{
      privatekeyjava2dotnet(){
          this.request("rsaprivatekeyjava2dotnet");
      },
      privatekeydotnet2java(){
          this.request("rsaprivatekeydotnet2java");
      },
      publickeyjava2dotnet(){
          this.request("rsapublickeyjava2dotnet");
      },
      publickeydotnet2java(){
          this.request("rsapublickeydotnet2java");
      },
      request(action){
          if(this.origin==""){
              return;
          }
          requestOption.body = '"'+this.origin+'"';
        fetch(`${this.serverUrl}/encryption/${action}`,requestOption)
            .then(res=> res.text())
            .then(txt => this.aftercalc = txt)
            .catch(ex => {this.aftercalc = JSON.stringify(ex)});
      },
      clearContent(){
          this.origin = this.aftercalc = "";
      }
  }

}
</script>
