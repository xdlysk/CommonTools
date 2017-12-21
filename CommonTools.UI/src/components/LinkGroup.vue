<template>
  <div class="panel panel-info">
    <div class="panel-heading">
        <h3 class="panel-title">{{category}}</h3>
    </div>
    <div class="panel-body">
        <span v-for="link in links" v-bind:key="link.id"><a v-bind:href="link.url" target="_blank">{{link.text}}</a></span>
    </div>
</div>
</template>
<script>
export default {
  name:'linkgroup',
  props:['category','links']
}
</script>
<style scoped>
span{
    padding: 5px;
    margin: 5px;
}
</style>


