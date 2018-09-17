import { PostService} from './../services/post.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent implements OnInit {
posts;

constructor(private postService: PostService) {}

  ngOnInit() {
		this.postService.getPosts().subscribe(posts => this.posts = posts);
  }

}
