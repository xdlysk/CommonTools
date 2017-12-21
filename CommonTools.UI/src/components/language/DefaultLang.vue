<template>
<div>
<codemirror v-model="code" :options="cmOptions"></codemirror>

  <button class="btn btn-default" v-on:click="formatter">格式化</button>

</div>
  
</template>
<script>
// require component
import { codemirror } from 'vue-codemirror'
 
// require styles
import 'codemirror/lib/codemirror.css'

import beautify from 'js-beautify';

export default {
  name:'default-lang',
  data(){
    return {
        code: 'const a = 10',
        cmOptions: {
            // codemirror options
            tabSize: 4,
            mode: 'text/javascript',
            theme: 'base16-dark',
            lineNumbers: true,
            line: true,
            // more codemirror options, 更多 codemirror 的高级配置...
        }
        }
  },
  methods:{
      formatter(){
          this.code = beautify(this.code,{indent_size:2});
      }
  },
  components:{
      codemirror
  }
}
</script>
