<template>
  <div class="row">
      <div class="col-md-6 col-md-offset-3">
        <h2>搜索引擎</h2>
        <div class="input-group">
            <input type="text" class="form-control" v-model="searchKey" aria-label="..." placeholder="输入关键字并选择对应的搜索引擎">
            <div class="input-group-btn">
                <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">GO!<span class="caret"></span></button>
                <ul class="dropdown-menu dropdown-menu-right">
                    <li><a href="#" v-on:click="search('google')">Google</a></li>
                    <li><a href="#" v-on:click="search('baidu')">Baidu</a></li>
                    <li><a href="#" v-on:click="search('bing')">Bing</a></li>
                </ul>
            </div><!-- /btn-group -->
        </div>

    </div>
    <div class="col-md-12">
        <h2>链接收藏</h2>
        <linkgroup v-for="lg in staticData" v-bind:category="lg.category" v-bind:links="lg.links" v-bind:key="lg.id"></linkgroup>
    </div>
  </div>
</template>
<script>
import LinkGroup from '@/components/LinkGroup';
import StaticData from '@/assets/js/staticdata';

export default {
  name:'index',
  components:{
      linkgroup:LinkGroup,
      StaticData
  },
  data(){
      return {
          searchKey:'',
          staticData:StaticData
      }
  },
  methods:{
      search(type){
          if(type==='google'){
              window.open(`https://www.google.com/search?q=${encodeURI(this.searchKey)}`);
          }
          else if(type==='baidu'){
              window.open(`https://www.baidu.com/s?wd=${encodeURI(this.searchKey)}`);
          }
          else if(type ==='bing'){
              window.open(`https://cn.bing.com/search?q=${encodeURI(this.searchKey)}`);
          }
      }
  }
}
</script>
