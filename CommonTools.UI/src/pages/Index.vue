<template>
  <div class="row">
      <div class="col-md-12">
        <h2>搜索引擎</h2>
        <div class="input-group input-group-lg">
            <div class="input-group-btn">
                <button type="button" class="btn btn-success dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">{{currentSearchEngine}}<span class="caret"></span></button>
                <ul class="dropdown-menu">
                    <li><a href="#" v-on:click="changeSearch('google')">Google</a></li>
                    <li><a href="#" v-on:click="changeSearch('baidu')">Baidu</a></li>
                    <li><a href="#" v-on:click="changeSearch('bing')">Bing</a></li>
                </ul>
            </div>
            <input type="text" class="form-control" v-model="searchKey" v-on:keydown.enter="search" aria-label="..." placeholder="选择对应的搜索引擎并输入关键字，回车或点击GO开始">
             <span class="input-group-btn">
                <button class="btn btn-primary" type="button" v-on:click="search">Go!</button>
            </span>
        </div>

    </div>
    <div class="col-md-12">
        <h2>链接收藏</h2>
        <linkgroup v-for="lg in staticData" v-bind:category="lg.category" v-bind:links="lg.links" v-bind:key="lg.id"></linkgroup>
    </div>
  </div>
</template>
<script>
import LinkGroup from "@/components/LinkGroup";
import StaticData from "@/assets/js/staticdata";

export default {
  name: "index",
  components: {
    linkgroup: LinkGroup,
    StaticData
  },
  data() {
    return {
      currentSearchEngine: "google",
      searchKey: "",
      staticData: StaticData
    };
  },
  methods: {
    search() {
      var type = this.currentSearchEngine;
      if (type === "google") {
        window.open(
          `https://www.google.com/search?q=${encodeURI(this.searchKey)}`
        );
      } else if (type === "baidu") {
        window.open(`https://www.baidu.com/s?wd=${encodeURI(this.searchKey)}`);
      } else if (type === "bing") {
        window.open(
          `https://cn.bing.com/search?q=${encodeURI(this.searchKey)}`
        );
      }
    },
    changeSearch(type) {
      this.currentSearchEngine = type;
    }
  }
};
</script>
