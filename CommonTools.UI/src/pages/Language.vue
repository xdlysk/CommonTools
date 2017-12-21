<template>
    <div class="row">
      <ul class="nav nav-tabs">
            <li class="active">
                <a href="#js" data-toggle="tab">
                    JS处理
                </a>
            </li>
            <li>
                <a href="#other" data-toggle="tab">
                    其他
                </a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="js">
                <defaultlang></defaultlang>
            </div>
            <div class="tab-pane fade in" id="other">
            </div>
        </div>
      
  </div>
</template>
<script>
import DefaultLang from '@/components/language/DefaultLang';

export default {
  name:'language',
  components:{
      defaultlang:DefaultLang
  }
}
</script>
