<template>
  <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">Base64图片互转</h3>
    </div>
    <div class="panel-body">
        <div class="form-group">
            <div class="col-md-6">
                <textarea class="form-control" rows="14" v-model="base64"></textarea>
            </div>
      <div class="col-md-6">
          <div class="well">
          <img v-bind:src="imageData"/>
          </div>
          <input type="file" name="image" id="image" v-on:change="readfile" placeholder="选择图片将自动转换为base64">
      </div>      
        </div>
        <div>
            目前支持png,jpeg,gif格式
        </div>
    </div>
</div>
</template>
<script>
const imageTypeMapping={
    'iVB':'png',
    '/9j':'jpeg',
    'R0l':'gif'
};
export default {
  name:'base64image',
  data(){
      return{
          base64:''
      }
  },
  computed:{
      imageData(){
          if(this.base64 === ''){
              return;
          }
          if(this.base64.startsWith('data')){
              return this.base64;
          }
          for(var item in imageTypeMapping){
              
              if(this.base64.startsWith(item))
              {
                  return `data:image/${imageTypeMapping[item]};base64,${this.base64}`;
              }
          }
      }
  },
  methods:{
      base642image(){},
      image2base64(){},
      readfile(event){
          var that = this;
          var file = event.target.files[0];  
            if(window.FileReader) {  
                var fr = new FileReader();  
                fr.onloadend = function(e) {  
                    that.base64 = e.target.result;  
                };  
                fr.readAsDataURL(file);  
            }  
      }
  }
}
</script>
