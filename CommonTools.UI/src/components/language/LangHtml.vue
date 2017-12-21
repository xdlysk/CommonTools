<template>
<div>
<codemirror v-model="code" :options="cmOptions"></codemirror>

  <button class="btn btn-primary" v-on:click="formatter">格式化</button>
</div>
  
</template>
<script>
import { codemirror } from 'vue-codemirror'
import 'codemirror/lib/codemirror.css'

import beautify from 'js-beautify';

export default {
  name:'langhtml',
  data(){
    return {
        code: '<html></html>',
        cmOptions: {
            // codemirror options
            tabSize: 4,
            mode: 'html',
            theme: "base16-dark",
            lineNumbers: true,
            line: true
        }
        }
  },
  methods:{
      formatter(){
          this.code = beautify.html(this.code,{indent_size:2});
      }
  },
  components:{
      codemirror
  }
}
</script>