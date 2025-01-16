import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCilindroComponent } from './create-cilindro.component';

describe('CreateCilindroComponent', () => {
  let component: CreateCilindroComponent;
  let fixture: ComponentFixture<CreateCilindroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateCilindroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateCilindroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
