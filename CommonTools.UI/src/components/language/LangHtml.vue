<template>
<div>
<codemirror v-model="code" :options="cmOptions"></codemirror>

  <button class="btn btn-primary" v-on:click="formatter">格式化</button>
</div>
  
</template>
<script>
import { codemirror } from 'vue-codemirror'
import 'codemirror/lib/codemirror.css'

  // language
  import 'codemirror/mode/xml/xml.js'
  // require active-line.js
  import'codemirror/addon/selection/active-line.js'
  // autoCloseTags
  import'codemirror/addon/edit/closetag.js'

import beautify from 'js-beautify';

export default {
  name:'langhtml',
  data(){
    return {
        code: '',
        cmOptions: {
          tabSize: 4,
          styleActiveLine: true,
          lineNumbers: true,
          autoCloseTags: true,
          line: true,
          mode: 'text/html',
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