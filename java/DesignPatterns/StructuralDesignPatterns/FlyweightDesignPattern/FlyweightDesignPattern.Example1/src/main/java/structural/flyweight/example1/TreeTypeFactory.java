package structural.flyweight.example1;

import java.util.HashMap;
import java.util.Map;

public class TreeTypeFactory {
    private final Map<String, ITreeType> treeTypes = new HashMap<>();

    public ITreeType getTreeType(String name, String color, String texture) {
        String key = name + "_" + color + "_" + texture;
        return treeTypes.computeIfAbsent(key, k -> new TreeType(name, color, texture));
    }

    public int getTreeTypeCount() { return treeTypes.size(); }
}
