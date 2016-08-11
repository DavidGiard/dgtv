import { Component } from '@angular/core';

@Component({
  selector: 'embedded-video',
  template: '<iframe src="{{videoUrl}}/player" width="560" height="315" allowFullScreen frameBorder="0"></iframe>' ,
})
export class EmbeddedVideoComponent {
    videoUrl: string = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437";
}
