public enum Resource {
	Wood, Stone
}

public class ResourceSet {
	public int wood;
	public int stone;

	public ResourceSet() {
		wood = 0;
		stone = 0;
	}
	
	public ResourceSet(int wood, int stone) {
		this.wood = wood;
		this.stone = stone;
	}

	public void ResetResourceSet() {
		wood = 0;
		stone = 0;
	}
}